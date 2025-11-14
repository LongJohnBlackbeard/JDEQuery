using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L104 - .
/// </summary>
public class F15L104 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHMCU.
        /// </summary>
        public const string EHMCU = "EHMCU";

        /// <summary>
        /// EHEPRD.
        /// </summary>
        public const string EHEPRD = "EHEPRD";

        /// <summary>
        /// EHRVNB.
        /// </summary>
        public const string EHRVNB = "EHRVNB";

        /// <summary>
        /// EHDS50.
        /// </summary>
        public const string EHDS50 = "EHDS50";

        /// <summary>
        /// EHEPRT.
        /// </summary>
        public const string EHEPRT = "EHEPRT";

        /// <summary>
        /// EHEPVT.
        /// </summary>
        public const string EHEPVT = "EHEPVT";

        /// <summary>
        /// EHUR01.
        /// </summary>
        public const string EHUR01 = "EHUR01";

        /// <summary>
        /// EHUR02.
        /// </summary>
        public const string EHUR02 = "EHUR02";

        /// <summary>
        /// EHUR03.
        /// </summary>
        public const string EHUR03 = "EHUR03";

        /// <summary>
        /// EHUR04.
        /// </summary>
        public const string EHUR04 = "EHUR04";

        /// <summary>
        /// EHUR05.
        /// </summary>
        public const string EHUR05 = "EHUR05";

        /// <summary>
        /// EHURCD.
        /// </summary>
        public const string EHURCD = "EHURCD";

        /// <summary>
        /// EHURDT.
        /// </summary>
        public const string EHURDT = "EHURDT";

        /// <summary>
        /// EHURAT.
        /// </summary>
        public const string EHURAT = "EHURAT";

        /// <summary>
        /// EHURAB.
        /// </summary>
        public const string EHURAB = "EHURAB";

        /// <summary>
        /// EHURRF.
        /// </summary>
        public const string EHURRF = "EHURRF";

        /// <summary>
        /// EHTORG.
        /// </summary>
        public const string EHTORG = "EHTORG";

        /// <summary>
        /// EHENTJ.
        /// </summary>
        public const string EHENTJ = "EHENTJ";

        /// <summary>
        /// EHJOBN.
        /// </summary>
        public const string EHJOBN = "EHJOBN";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHUPMJ.
        /// </summary>
        public const string EHUPMJ = "EHUPMJ";

        /// <summary>
        /// EHUPMT.
        /// </summary>
        public const string EHUPMT = "EHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F15L104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHMCU", "EHMCU", JdeDataType.String, 24, true, true),
        new JdeField("EHEPRD", "EHEPRD", JdeDataType.String, 20, true, true),
        new JdeField("EHRVNB", "EHRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("EHDS50", "EHDS50", JdeDataType.String, 100),
        new JdeField("EHEPRT", "EHEPRT", JdeDataType.String, 2),
        new JdeField("EHEPVT", "EHEPVT", JdeDataType.String, 2),
        new JdeField("EHUR01", "EHUR01", JdeDataType.String, 6),
        new JdeField("EHUR02", "EHUR02", JdeDataType.String, 6),
        new JdeField("EHUR03", "EHUR03", JdeDataType.String, 6),
        new JdeField("EHUR04", "EHUR04", JdeDataType.String, 6),
        new JdeField("EHUR05", "EHUR05", JdeDataType.String, 6),
        new JdeField("EHURCD", "EHURCD", JdeDataType.String, 4),
        new JdeField("EHURDT", "EHURDT", JdeDataType.Numeric),
        new JdeField("EHURAT", "EHURAT", JdeDataType.Numeric),
        new JdeField("EHURAB", "EHURAB", JdeDataType.Numeric),
        new JdeField("EHURRF", "EHURRF", JdeDataType.String, 30),
        new JdeField("EHTORG", "EHTORG", JdeDataType.String, 20),
        new JdeField("EHENTJ", "EHENTJ", JdeDataType.Numeric),
        new JdeField("EHJOBN", "EHJOBN", JdeDataType.String, 20),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHUPMJ", "EHUPMJ", JdeDataType.Numeric),
        new JdeField("EHUPMT", "EHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L104_0", "Primary Key on EHMCU, EHEPRD, EHRVNB", new[] { "EHMCU", "EHEPRD", "EHRVNB" }, isUnique: true, isPrimaryKey: true)
    };
}
