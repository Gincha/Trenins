# Trenins


CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY xx_ap_hold_data_pkg AS

    l_status_success VARCHAR2(1) := 'S';

    PROCEDURE math_invoices (
        p_file_name IN VARCHAR2
    ) IS

        l_procedure_name      VARCHAR(30) := 'match_invoices';
        l_status              VARCHAR2(4) := l_status_success;
        l_business_unit_name  int_in_ap_hold_data.business_unit_name%TYPE;
        l_supplier_number     poz_suppliers.segment1%TYPE;
        l_supplier_name       hz_parties.party_name%TYPE;
        l_invoice_number      ap_invoices_all.invoice_num%TYPE;
        l_invoice_id          ap_invoices_all.invoice_id%TYPE;
        l_message             int_out_ap_hold_data.message%TYPE;
    BEGIN
        FOR i IN (
            SELECT
                source_system,
                file_name,
                data_type,
                status
            FROM
                interface_files x
            WHERE
                    x.status = 'N'
                AND x.file_name = nvl(p_file_name, x.file_name)
        ) LOOP
            FOR l_data IN (
                SELECT
                    *
                FROM
                    int_in_ap_hold_data
                WHERE
                        file_name = p_file_name
                    AND status = 'N'
            ) LOOP
                l_business_unit_name := l_data.business_unit_name;
                l_supplier_number := l_data.supplier_number;
                l_supplier_name := l_data.supplier_name;
                l_invoice_number := l_data.invoice_number;
                dbms_output.put_line('strada ar invoisu nr: '
                                     || l_invoice_number
                                     || ' suppl name: '
                                     || l_supplier_name
                                     || ' suppl number: '
                                     || l_supplier_number);

                IF ( l_supplier_number IS NOT NULL ) THEN
                    BEGIN
                        SELECT
                            aia.invoice_id
                        INTO l_invoice_id
                        FROM
                                 ap_invoices_all aia
                            JOIN poz_suppliers ps ON ( aia.vendor_id = ps.vendor_id )
                        WHERE
                                aia.invoice_num = l_data.invoice_number
                            AND ps.segment1 = l_supplier_number;

                    EXCEPTION
                        WHEN no_data_found THEN
                            l_message := 'INVOICE ID NOT FOUND';
                            l_status := 'E';
                        WHEN too_many_rows THEN
                            l_message := 'INVOICE ID NOT CERTAIN';
                            l_status := 'E';
                    END;
                ELSE
                    BEGIN
                        SELECT
                            aia.invoice_id
                        INTO l_invoice_id
                        FROM
                                 ap_invoices_all aia
                            JOIN poz_suppliers  ps ON ( aia.vendor_id = ps.vendor_id )
                            JOIN hz_parties     hp ON ( ps.party_id = hp.party_id )
                        WHERE
                                aia.invoice_num = l_data.invoice_number
                            AND hp.party_name = l_data.supplier_name;

                    EXCEPTION
                        WHEN no_data_found THEN
                            l_message := 'INVOICE ID NOT FOUND';
                            l_status := 'E';
                        WHEN too_many_rows THEN
                            l_message := 'INVOICE ID NOT CERTAIN';
                            l_status := 'E';
                    END;
                END IF;

                IF ( l_status = l_status_success ) THEN
                    INSERT INTO int_out_ap_hold_data (
                        line_id,
                        invoice_id,
                        business_unit_name,
                        supplier_name,
                        supplier_number,
                        invoice_number,
                        hold_lookup_code,
                        release_lookup_code,
                        status,
                        creation_date,
                        file_name
                    ) VALUES (
                        int_out_ap_hold_data_seq.NEXTVAL,
                        l_invoice_id,
                        l_business_unit_name,
                        l_data.supplier_name,
                        l_data.supplier_number,
                        l_data.invoice_number,
                        l_data.hold_lookup_code,
                        l_data.release_lookup_code,
                        'N',
                        sysdate,
                        p_file_name
                    );

                END IF;

                UPDATE int_in_ap_hold_data
                SET
                    status = l_status,
                    message = l_message
                WHERE
                    line_id = l_data.line_id;

            END LOOP;

            COMMIT;
        END LOOP;
    END;

END xx_ap_hold_data_pkg;
