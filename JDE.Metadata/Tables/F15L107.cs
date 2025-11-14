using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L107 - .
/// </summary>
public class F15L107 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EFMCU.
        /// </summary>
        public const string EFMCU = "EFMCU";

        /// <summary>
        /// EFRVNB.
        /// </summary>
        public const string EFRVNB = "EFRVNB";

        /// <summary>
        /// EFARRID.
        /// </summary>
        public const string EFARRID = "EFARRID";

        /// <summary>
        /// EFDL01.
        /// </summary>
        public const string EFDL01 = "EFDL01";

        /// <summary>
        /// EFASSD.
        /// </summary>
        public const string EFASSD = "EFASSD";

        /// <summary>
        /// EFAACT.
        /// </summary>
        public const string EFAACT = "EFAACT";

        /// <summary>
        /// EFEPRD.
        /// </summary>
        public const string EFEPRD = "EFEPRD";

        /// <summary>
        /// EFSOID.
        /// </summary>
        public const string EFSOID = "EFSOID";

        /// <summary>
        /// EFBCRI.
        /// </summary>
        public const string EFBCRI = "EFBCRI";

        /// <summary>
        /// EFUDGP.
        /// </summary>
        public const string EFUDGP = "EFUDGP";

        /// <summary>
        /// EFURAB.
        /// </summary>
        public const string EFURAB = "EFURAB";

        /// <summary>
        /// EFURAT.
        /// </summary>
        public const string EFURAT = "EFURAT";

        /// <summary>
        /// EFURCD.
        /// </summary>
        public const string EFURCD = "EFURCD";

        /// <summary>
        /// EFURDT.
        /// </summary>
        public const string EFURDT = "EFURDT";

        /// <summary>
        /// EFURRF.
        /// </summary>
        public const string EFURRF = "EFURRF";

        /// <summary>
        /// EFMKEY.
        /// </summary>
        public const string EFMKEY = "EFMKEY";

        /// <summary>
        /// EFUSER.
        /// </summary>
        public const string EFUSER = "EFUSER";

        /// <summary>
        /// EFPID.
        /// </summary>
        public const string EFPID = "EFPID";

        /// <summary>
        /// EFUPMJ.
        /// </summary>
        public const string EFUPMJ = "EFUPMJ";

        /// <summary>
        /// EFUPMT.
        /// </summary>
        public const string EFUPMT = "EFUPMT";

        /// <summary>
        /// EFTORG.
        /// </summary>
        public const string EFTORG = "EFTORG";

        /// <summary>
        /// EFENTJ.
        /// </summary>
        public const string EFENTJ = "EFENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15L107";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EFMCU", "EFMCU", JdeDataType.String, 24, true, true),
        new JdeField("EFRVNB", "EFRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("EFARRID", "EFARRID", JdeDataType.String, 20, true, true),
        new JdeField("EFDL01", "EFDL01", JdeDataType.String, 60),
        new JdeField("EFASSD", "EFASSD", JdeDataType.String, 20),
        new JdeField("EFAACT", "EFAACT", JdeDataType.String, 4),
        new JdeField("EFEPRD", "EFEPRD", JdeDataType.String, 20),
        new JdeField("EFSOID", "EFSOID", JdeDataType.String, 20),
        new JdeField("EFBCRI", "EFBCRI", JdeDataType.String, 20),
        new JdeField("EFUDGP", "EFUDGP", JdeDataType.String, 20),
        new JdeField("EFURAB", "EFURAB", JdeDataType.Numeric),
        new JdeField("EFURAT", "EFURAT", JdeDataType.Numeric),
        new JdeField("EFURCD", "EFURCD", JdeDataType.String, 4),
        new JdeField("EFURDT", "EFURDT", JdeDataType.Numeric),
        new JdeField("EFURRF", "EFURRF", JdeDataType.String, 30),
        new JdeField("EFMKEY", "EFMKEY", JdeDataType.String, 30),
        new JdeField("EFUSER", "EFUSER", JdeDataType.String, 20),
        new JdeField("EFPID", "EFPID", JdeDataType.String, 20),
        new JdeField("EFUPMJ", "EFUPMJ", JdeDataType.Numeric),
        new JdeField("EFUPMT", "EFUPMT", JdeDataType.Numeric),
        new JdeField("EFTORG", "EFTORG", JdeDataType.String, 20),
        new JdeField("EFENTJ", "EFENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L107_0", "Primary Key on EFMCU, EFRVNB, EFARRID", new[] { "EFMCU", "EFRVNB", "EFARRID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L107_2", "Index on EFARRID", new[] { "EFARRID" })
    };
}
