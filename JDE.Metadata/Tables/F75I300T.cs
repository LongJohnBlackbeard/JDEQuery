using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I300T - .
/// </summary>
public class F75I300T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GTKCO.
        /// </summary>
        public const string GTKCO = "GTKCO";

        /// <summary>
        /// GTDCT.
        /// </summary>
        public const string GTDCT = "GTDCT";

        /// <summary>
        /// GTDOC.
        /// </summary>
        public const string GTDOC = "GTDOC";

        /// <summary>
        /// GTI75INVNO.
        /// </summary>
        public const string GTI75INVNO = "GTI75INVNO";

        /// <summary>
        /// GTI75INVST.
        /// </summary>
        public const string GTI75INVST = "GTI75INVST";

        /// <summary>
        /// GTI75RMRK.
        /// </summary>
        public const string GTI75RMRK = "GTI75RMRK";

        /// <summary>
        /// GTTRDJ.
        /// </summary>
        public const string GTTRDJ = "GTTRDJ";

        /// <summary>
        /// GTUSER.
        /// </summary>
        public const string GTUSER = "GTUSER";

        /// <summary>
        /// GTPID.
        /// </summary>
        public const string GTPID = "GTPID";

        /// <summary>
        /// GTJOBN.
        /// </summary>
        public const string GTJOBN = "GTJOBN";

        /// <summary>
        /// GTUPMJ.
        /// </summary>
        public const string GTUPMJ = "GTUPMJ";

        /// <summary>
        /// GTUPMT.
        /// </summary>
        public const string GTUPMT = "GTUPMT";

        /// <summary>
        /// GTFUT1.
        /// </summary>
        public const string GTFUT1 = "GTFUT1";

        /// <summary>
        /// GTFUTCHAR1.
        /// </summary>
        public const string GTFUTCHAR1 = "GTFUTCHAR1";

        /// <summary>
        /// GTFUTSTR1.
        /// </summary>
        public const string GTFUTSTR1 = "GTFUTSTR1";

        /// <summary>
        /// GTFUTMATH1.
        /// </summary>
        public const string GTFUTMATH1 = "GTFUTMATH1";

        /// <summary>
        /// GTI75IRN.
        /// </summary>
        public const string GTI75IRN = "GTI75IRN";

        /// <summary>
        /// GTI75IRD.
        /// </summary>
        public const string GTI75IRD = "GTI75IRD";
    }

    /// <inheritdoc />
    public override string TableName => "F75I300T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GTKCO", "GTKCO", JdeDataType.String, 10, true, true),
        new JdeField("GTDCT", "GTDCT", JdeDataType.String, 4, true, true),
        new JdeField("GTDOC", "GTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GTI75INVNO", "GTI75INVNO", JdeDataType.String, 50),
        new JdeField("GTI75INVST", "GTI75INVST", JdeDataType.String, 2),
        new JdeField("GTI75RMRK", "GTI75RMRK", JdeDataType.String, 120),
        new JdeField("GTTRDJ", "GTTRDJ", JdeDataType.Numeric),
        new JdeField("GTUSER", "GTUSER", JdeDataType.String, 20),
        new JdeField("GTPID", "GTPID", JdeDataType.String, 20),
        new JdeField("GTJOBN", "GTJOBN", JdeDataType.String, 20),
        new JdeField("GTUPMJ", "GTUPMJ", JdeDataType.Numeric),
        new JdeField("GTUPMT", "GTUPMT", JdeDataType.Numeric),
        new JdeField("GTFUT1", "GTFUT1", JdeDataType.Numeric),
        new JdeField("GTFUTCHAR1", "GTFUTCHAR1", JdeDataType.String, 2),
        new JdeField("GTFUTSTR1", "GTFUTSTR1", JdeDataType.String, 100),
        new JdeField("GTFUTMATH1", "GTFUTMATH1", JdeDataType.Numeric),
        new JdeField("GTI75IRN", "GTI75IRN", JdeDataType.String, 60),
        new JdeField("GTI75IRD", "GTI75IRD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I300T_0", "Primary Key on GTKCO, GTDCT, GTDOC", new[] { "GTKCO", "GTDCT", "GTDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
