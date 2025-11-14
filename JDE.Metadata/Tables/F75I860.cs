using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I860 - .
/// </summary>
public class F75I860 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BNUKID.
        /// </summary>
        public const string BNUKID = "BNUKID";

        /// <summary>
        /// BNKCOO.
        /// </summary>
        public const string BNKCOO = "BNKCOO";

        /// <summary>
        /// BNDCTO.
        /// </summary>
        public const string BNDCTO = "BNDCTO";

        /// <summary>
        /// BNDOCO.
        /// </summary>
        public const string BNDOCO = "BNDOCO";

        /// <summary>
        /// BNLNID.
        /// </summary>
        public const string BNLNID = "BNLNID";

        /// <summary>
        /// BNKCO.
        /// </summary>
        public const string BNKCO = "BNKCO";

        /// <summary>
        /// BNDCT.
        /// </summary>
        public const string BNDCT = "BNDCT";

        /// <summary>
        /// BNDOC.
        /// </summary>
        public const string BNDOC = "BNDOC";

        /// <summary>
        /// BNSFX.
        /// </summary>
        public const string BNSFX = "BNSFX";

        /// <summary>
        /// BNI75INVNO.
        /// </summary>
        public const string BNI75INVNO = "BNI75INVNO";

        /// <summary>
        /// BNDGL.
        /// </summary>
        public const string BNDGL = "BNDGL";

        /// <summary>
        /// BNI75HSNC.
        /// </summary>
        public const string BNI75HSNC = "BNI75HSNC";

        /// <summary>
        /// BNI75SERAC.
        /// </summary>
        public const string BNI75SERAC = "BNI75SERAC";

        /// <summary>
        /// BNI75EWBN.
        /// </summary>
        public const string BNI75EWBN = "BNI75EWBN";

        /// <summary>
        /// BNI75EWBS.
        /// </summary>
        public const string BNI75EWBS = "BNI75EWBS";

        /// <summary>
        /// BNI75SDNO.
        /// </summary>
        public const string BNI75SDNO = "BNI75SDNO";

        /// <summary>
        /// BNI75SDDT.
        /// </summary>
        public const string BNI75SDDT = "BNI75SDDT";

        /// <summary>
        /// BNITM.
        /// </summary>
        public const string BNITM = "BNITM";

        /// <summary>
        /// BNLITM.
        /// </summary>
        public const string BNLITM = "BNLITM";

        /// <summary>
        /// BNUSER.
        /// </summary>
        public const string BNUSER = "BNUSER";

        /// <summary>
        /// BNPID.
        /// </summary>
        public const string BNPID = "BNPID";

        /// <summary>
        /// BNJOBN.
        /// </summary>
        public const string BNJOBN = "BNJOBN";

        /// <summary>
        /// BNUPMJ.
        /// </summary>
        public const string BNUPMJ = "BNUPMJ";

        /// <summary>
        /// BNUPMT.
        /// </summary>
        public const string BNUPMT = "BNUPMT";

        /// <summary>
        /// BNYFUTDT1.
        /// </summary>
        public const string BNYFUTDT1 = "BNYFUTDT1";

        /// <summary>
        /// BNFUT6.
        /// </summary>
        public const string BNFUT6 = "BNFUT6";

        /// <summary>
        /// BNYT04.
        /// </summary>
        public const string BNYT04 = "BNYT04";

        /// <summary>
        /// BNYFLAG.
        /// </summary>
        public const string BNYFLAG = "BNYFLAG";

        /// <summary>
        /// BNYNUM1.
        /// </summary>
        public const string BNYNUM1 = "BNYNUM1";

        /// <summary>
        /// BNI75IDCNO.
        /// </summary>
        public const string BNI75IDCNO = "BNI75IDCNO";

        /// <summary>
        /// BNI75IDCDT.
        /// </summary>
        public const string BNI75IDCDT = "BNI75IDCDT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I860";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BNUKID", "BNUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BNKCOO", "BNKCOO", JdeDataType.String, 10),
        new JdeField("BNDCTO", "BNDCTO", JdeDataType.String, 4),
        new JdeField("BNDOCO", "BNDOCO", JdeDataType.Numeric),
        new JdeField("BNLNID", "BNLNID", JdeDataType.Numeric),
        new JdeField("BNKCO", "BNKCO", JdeDataType.String, 10),
        new JdeField("BNDCT", "BNDCT", JdeDataType.String, 4),
        new JdeField("BNDOC", "BNDOC", JdeDataType.Numeric),
        new JdeField("BNSFX", "BNSFX", JdeDataType.String, 6),
        new JdeField("BNI75INVNO", "BNI75INVNO", JdeDataType.String, 50),
        new JdeField("BNDGL", "BNDGL", JdeDataType.Numeric),
        new JdeField("BNI75HSNC", "BNI75HSNC", JdeDataType.String, 40),
        new JdeField("BNI75SERAC", "BNI75SERAC", JdeDataType.String, 40),
        new JdeField("BNI75EWBN", "BNI75EWBN", JdeDataType.String, 70),
        new JdeField("BNI75EWBS", "BNI75EWBS", JdeDataType.String, 2),
        new JdeField("BNI75SDNO", "BNI75SDNO", JdeDataType.String, 50),
        new JdeField("BNI75SDDT", "BNI75SDDT", JdeDataType.Numeric),
        new JdeField("BNITM", "BNITM", JdeDataType.Numeric),
        new JdeField("BNLITM", "BNLITM", JdeDataType.String, 50),
        new JdeField("BNUSER", "BNUSER", JdeDataType.String, 20),
        new JdeField("BNPID", "BNPID", JdeDataType.String, 20),
        new JdeField("BNJOBN", "BNJOBN", JdeDataType.String, 20),
        new JdeField("BNUPMJ", "BNUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("BNUPMT", "BNUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("BNYFUTDT1", "BNYFUTDT1", JdeDataType.Numeric),
        new JdeField("BNFUT6", "BNFUT6", JdeDataType.String, 60),
        new JdeField("BNYT04", "BNYT04", JdeDataType.String, 2),
        new JdeField("BNYFLAG", "BNYFLAG", JdeDataType.String, 2),
        new JdeField("BNYNUM1", "BNYNUM1", JdeDataType.Numeric),
        new JdeField("BNI75IDCNO", "BNI75IDCNO", JdeDataType.String, 50),
        new JdeField("BNI75IDCDT", "BNI75IDCDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I860_0", "Primary Key on BNUKID, BNUPMJ, BNUPMT", new[] { "BNUKID", "BNUPMJ", "BNUPMT" }, isUnique: true, isPrimaryKey: true)
    };
}
