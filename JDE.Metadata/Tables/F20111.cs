using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F20111 - .
/// </summary>
public class F20111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHEXRPTTYP.
        /// </summary>
        public const string EHEXRPTTYP = "EHEXRPTTYP";

        /// <summary>
        /// EHEXRPTNUM.
        /// </summary>
        public const string EHEXRPTNUM = "EHEXRPTNUM";

        /// <summary>
        /// EHEMPLOYID.
        /// </summary>
        public const string EHEMPLOYID = "EHEMPLOYID";

        /// <summary>
        /// EHWRKSTNID.
        /// </summary>
        public const string EHWRKSTNID = "EHWRKSTNID";

        /// <summary>
        /// EHDTECRT.
        /// </summary>
        public const string EHDTECRT = "EHDTECRT";

        /// <summary>
        /// EHEXRPTDES.
        /// </summary>
        public const string EHEXRPTDES = "EHEXRPTDES";

        /// <summary>
        /// EHEXRPTDTE.
        /// </summary>
        public const string EHEXRPTDTE = "EHEXRPTDTE";

        /// <summary>
        /// EHMGRID.
        /// </summary>
        public const string EHMGRID = "EHMGRID";

        /// <summary>
        /// EHAUDITID.
        /// </summary>
        public const string EHAUDITID = "EHAUDITID";

        /// <summary>
        /// EHEXRPTSTA.
        /// </summary>
        public const string EHEXRPTSTA = "EHEXRPTSTA";

        /// <summary>
        /// EHTOTEXP.
        /// </summary>
        public const string EHTOTEXP = "EHTOTEXP";

        /// <summary>
        /// EHREIMBTOT.
        /// </summary>
        public const string EHREIMBTOT = "EHREIMBTOT";

        /// <summary>
        /// EHNBILLTOT.
        /// </summary>
        public const string EHNBILLTOT = "EHNBILLTOT";

        /// <summary>
        /// EHMULTIPL.
        /// </summary>
        public const string EHMULTIPL = "EHMULTIPL";

        /// <summary>
        /// EHOFFLINE.
        /// </summary>
        public const string EHOFFLINE = "EHOFFLINE";

        /// <summary>
        /// EHDATEAPP.
        /// </summary>
        public const string EHDATEAPP = "EHDATEAPP";

        /// <summary>
        /// EHDATESUB.
        /// </summary>
        public const string EHDATESUB = "EHDATESUB";

        /// <summary>
        /// EHAUDITDTE.
        /// </summary>
        public const string EHAUDITDTE = "EHAUDITDTE";

        /// <summary>
        /// EHDTEPROC.
        /// </summary>
        public const string EHDTEPROC = "EHDTEPROC";

        /// <summary>
        /// EHADTEXRPT.
        /// </summary>
        public const string EHADTEXRPT = "EHADTEXRPT";

        /// <summary>
        /// EHREIMCRCY.
        /// </summary>
        public const string EHREIMCRCY = "EHREIMCRCY";

        /// <summary>
        /// EHCCRCRCY.
        /// </summary>
        public const string EHCCRCRCY = "EHCCRCRCY";

        /// <summary>
        /// EHBUSPURP.
        /// </summary>
        public const string EHBUSPURP = "EHBUSPURP";

        /// <summary>
        /// EHNUMEXP.
        /// </summary>
        public const string EHNUMEXP = "EHNUMEXP";

        /// <summary>
        /// EHNUMEXC.
        /// </summary>
        public const string EHNUMEXC = "EHNUMEXC";

        /// <summary>
        /// EHPEREXC.
        /// </summary>
        public const string EHPEREXC = "EHPEREXC";

        /// <summary>
        /// EHNUMFAIL.
        /// </summary>
        public const string EHNUMFAIL = "EHNUMFAIL";

        /// <summary>
        /// EHCASHADV.
        /// </summary>
        public const string EHCASHADV = "EHCASHADV";

        /// <summary>
        /// EHAN8.
        /// </summary>
        public const string EHAN8 = "EHAN8";

        /// <summary>
        /// EHCCREAMT.
        /// </summary>
        public const string EHCCREAMT = "EHCCREAMT";

        /// <summary>
        /// EHTORG.
        /// </summary>
        public const string EHTORG = "EHTORG";

        /// <summary>
        /// EHCO.
        /// </summary>
        public const string EHCO = "EHCO";

        /// <summary>
        /// EHACCTGMD.
        /// </summary>
        public const string EHACCTGMD = "EHACCTGMD";

        /// <summary>
        /// EHPOLICY.
        /// </summary>
        public const string EHPOLICY = "EHPOLICY";

        /// <summary>
        /// EHHMCU.
        /// </summary>
        public const string EHHMCU = "EHHMCU";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHJOBN.
        /// </summary>
        public const string EHJOBN = "EHJOBN";

        /// <summary>
        /// EHUPMJ.
        /// </summary>
        public const string EHUPMJ = "EHUPMJ";

        /// <summary>
        /// EHUPMT.
        /// </summary>
        public const string EHUPMT = "EHUPMT";

        /// <summary>
        /// EHAPDND.
        /// </summary>
        public const string EHAPDND = "EHAPDND";

        /// <summary>
        /// EHGOVUNTOT.
        /// </summary>
        public const string EHGOVUNTOT = "EHGOVUNTOT";
    }

    /// <inheritdoc />
    public override string TableName => "F20111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHEXRPTTYP", "EHEXRPTTYP", JdeDataType.String, 2, true, true),
        new JdeField("EHEXRPTNUM", "EHEXRPTNUM", JdeDataType.String, 20, true, true),
        new JdeField("EHEMPLOYID", "EHEMPLOYID", JdeDataType.Numeric, null, true, true),
        new JdeField("EHWRKSTNID", "EHWRKSTNID", JdeDataType.String, 20, true, true),
        new JdeField("EHDTECRT", "EHDTECRT", JdeDataType.Numeric, null, true, true),
        new JdeField("EHEXRPTDES", "EHEXRPTDES", JdeDataType.String, 80),
        new JdeField("EHEXRPTDTE", "EHEXRPTDTE", JdeDataType.Numeric),
        new JdeField("EHMGRID", "EHMGRID", JdeDataType.Numeric),
        new JdeField("EHAUDITID", "EHAUDITID", JdeDataType.Numeric),
        new JdeField("EHEXRPTSTA", "EHEXRPTSTA", JdeDataType.String, 6),
        new JdeField("EHTOTEXP", "EHTOTEXP", JdeDataType.Numeric),
        new JdeField("EHREIMBTOT", "EHREIMBTOT", JdeDataType.Numeric),
        new JdeField("EHNBILLTOT", "EHNBILLTOT", JdeDataType.Numeric),
        new JdeField("EHMULTIPL", "EHMULTIPL", JdeDataType.String, 2),
        new JdeField("EHOFFLINE", "EHOFFLINE", JdeDataType.String, 2),
        new JdeField("EHDATEAPP", "EHDATEAPP", JdeDataType.Numeric),
        new JdeField("EHDATESUB", "EHDATESUB", JdeDataType.Numeric),
        new JdeField("EHAUDITDTE", "EHAUDITDTE", JdeDataType.Numeric),
        new JdeField("EHDTEPROC", "EHDTEPROC", JdeDataType.Numeric),
        new JdeField("EHADTEXRPT", "EHADTEXRPT", JdeDataType.String, 2),
        new JdeField("EHREIMCRCY", "EHREIMCRCY", JdeDataType.String, 6),
        new JdeField("EHCCRCRCY", "EHCCRCRCY", JdeDataType.String, 6),
        new JdeField("EHBUSPURP", "EHBUSPURP", JdeDataType.String, 80),
        new JdeField("EHNUMEXP", "EHNUMEXP", JdeDataType.Numeric),
        new JdeField("EHNUMEXC", "EHNUMEXC", JdeDataType.Numeric),
        new JdeField("EHPEREXC", "EHPEREXC", JdeDataType.Numeric),
        new JdeField("EHNUMFAIL", "EHNUMFAIL", JdeDataType.Numeric),
        new JdeField("EHCASHADV", "EHCASHADV", JdeDataType.Numeric),
        new JdeField("EHAN8", "EHAN8", JdeDataType.Numeric),
        new JdeField("EHCCREAMT", "EHCCREAMT", JdeDataType.Numeric),
        new JdeField("EHTORG", "EHTORG", JdeDataType.String, 20),
        new JdeField("EHCO", "EHCO", JdeDataType.String, 10),
        new JdeField("EHACCTGMD", "EHACCTGMD", JdeDataType.String, 2),
        new JdeField("EHPOLICY", "EHPOLICY", JdeDataType.String, 10),
        new JdeField("EHHMCU", "EHHMCU", JdeDataType.String, 24),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHJOBN", "EHJOBN", JdeDataType.String, 20),
        new JdeField("EHUPMJ", "EHUPMJ", JdeDataType.Numeric),
        new JdeField("EHUPMT", "EHUPMT", JdeDataType.Numeric),
        new JdeField("EHAPDND", "EHAPDND", JdeDataType.Numeric),
        new JdeField("EHGOVUNTOT", "EHGOVUNTOT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F20111_0", "Primary Key on EHEXRPTTYP, EHEXRPTNUM, EHEMPLOYID, EHWRKSTNID, EHDTECRT", new[] { "EHEXRPTTYP", "EHEXRPTNUM", "EHEMPLOYID", "EHWRKSTNID", "EHDTECRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F20111_2", "Index on EHPOLICY", new[] { "EHPOLICY" }),
        new JdeIndex("F20111_3", "Index on EHEMPLOYID, EHMGRID, EHEXRPTSTA", new[] { "EHEMPLOYID", "EHMGRID", "EHEXRPTSTA" })
    };
}
