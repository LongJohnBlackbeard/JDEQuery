using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0018R - .
/// </summary>
public class F0018R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDKCO.
        /// </summary>
        public const string EDKCO = "EDKCO";

        /// <summary>
        /// EDDCT.
        /// </summary>
        public const string EDDCT = "EDDCT";

        /// <summary>
        /// EDDOCO.
        /// </summary>
        public const string EDDOCO = "EDDOCO";

        /// <summary>
        /// EDLNID.
        /// </summary>
        public const string EDLNID = "EDLNID";

        /// <summary>
        /// EDJELN.
        /// </summary>
        public const string EDJELN = "EDJELN";

        /// <summary>
        /// EDEXTL.
        /// </summary>
        public const string EDEXTL = "EDEXTL";

        /// <summary>
        /// EDSFX.
        /// </summary>
        public const string EDSFX = "EDSFX";

        /// <summary>
        /// EDSFXE.
        /// </summary>
        public const string EDSFXE = "EDSFXE";

        /// <summary>
        /// EDDGJ.
        /// </summary>
        public const string EDDGJ = "EDDGJ";

        /// <summary>
        /// EDAID.
        /// </summary>
        public const string EDAID = "EDAID";

        /// <summary>
        /// EDAA.
        /// </summary>
        public const string EDAA = "EDAA";

        /// <summary>
        /// EDATXA.
        /// </summary>
        public const string EDATXA = "EDATXA";

        /// <summary>
        /// EDSTAM.
        /// </summary>
        public const string EDSTAM = "EDSTAM";

        /// <summary>
        /// EDATXN.
        /// </summary>
        public const string EDATXN = "EDATXN";

        /// <summary>
        /// EDNRTA.
        /// </summary>
        public const string EDNRTA = "EDNRTA";

        /// <summary>
        /// EDBCRC.
        /// </summary>
        public const string EDBCRC = "EDBCRC";

        /// <summary>
        /// EDTXA1.
        /// </summary>
        public const string EDTXA1 = "EDTXA1";

        /// <summary>
        /// EDEXR1.
        /// </summary>
        public const string EDEXR1 = "EDEXR1";

        /// <summary>
        /// EDTXITM.
        /// </summary>
        public const string EDTXITM = "EDTXITM";

        /// <summary>
        /// EDFUT1.
        /// </summary>
        public const string EDFUT1 = "EDFUT1";

        /// <summary>
        /// EDFUT2.
        /// </summary>
        public const string EDFUT2 = "EDFUT2";

        /// <summary>
        /// EDFUT4.
        /// </summary>
        public const string EDFUT4 = "EDFUT4";

        /// <summary>
        /// EDUPMT.
        /// </summary>
        public const string EDUPMT = "EDUPMT";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F0018R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDKCO", "EDKCO", JdeDataType.String, 10, true, true),
        new JdeField("EDDCT", "EDDCT", JdeDataType.String, 4, true, true),
        new JdeField("EDDOCO", "EDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("EDLNID", "EDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("EDJELN", "EDJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDEXTL", "EDEXTL", JdeDataType.String, 4, true, true),
        new JdeField("EDSFX", "EDSFX", JdeDataType.String, 6, true, true),
        new JdeField("EDSFXE", "EDSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("EDDGJ", "EDDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("EDAID", "EDAID", JdeDataType.String, 16),
        new JdeField("EDAA", "EDAA", JdeDataType.Numeric),
        new JdeField("EDATXA", "EDATXA", JdeDataType.Numeric),
        new JdeField("EDSTAM", "EDSTAM", JdeDataType.Numeric),
        new JdeField("EDATXN", "EDATXN", JdeDataType.Numeric),
        new JdeField("EDNRTA", "EDNRTA", JdeDataType.Numeric),
        new JdeField("EDBCRC", "EDBCRC", JdeDataType.String, 6),
        new JdeField("EDTXA1", "EDTXA1", JdeDataType.String, 20),
        new JdeField("EDEXR1", "EDEXR1", JdeDataType.String, 4),
        new JdeField("EDTXITM", "EDTXITM", JdeDataType.Numeric, null, true, true),
        new JdeField("EDFUT1", "EDFUT1", JdeDataType.Numeric),
        new JdeField("EDFUT2", "EDFUT2", JdeDataType.Numeric),
        new JdeField("EDFUT4", "EDFUT4", JdeDataType.String, 50),
        new JdeField("EDUPMT", "EDUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0018R_0", "Primary Key on EDKCO, EDDCT, EDDOCO, EDLNID, EDJELN, EDEXTL, EDSFX, EDSFXE, EDTXITM, EDDGJ, EDUPMT, EDUPMJ", new[] { "EDKCO", "EDDCT", "EDDOCO", "EDLNID", "EDJELN", "EDEXTL", "EDSFX", "EDSFXE", "EDTXITM", "EDDGJ", "EDUPMT", "EDUPMJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0018R_2", "Index on EDKCO, EDDCT, EDDOCO, EDTXA1, EDEXR1, EDTXITM, EDDGJ, EDUPMT, EDUPMJ", new[] { "EDKCO", "EDDCT", "EDDOCO", "EDTXA1", "EDEXR1", "EDTXITM", "EDDGJ", "EDUPMT", "EDUPMJ" })
    };
}
