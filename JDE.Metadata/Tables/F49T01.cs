using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T01 - .
/// </summary>
public class F49T01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRCRFTY.
        /// </summary>
        public const string CRCRFTY = "CRCRFTY";

        /// <summary>
        /// CRNATIVE.
        /// </summary>
        public const string CRNATIVE = "CRNATIVE";

        /// <summary>
        /// CRCNICL.
        /// </summary>
        public const string CRCNICL = "CRCNICL";

        /// <summary>
        /// CRURCD.
        /// </summary>
        public const string CRURCD = "CRURCD";

        /// <summary>
        /// CRURDT.
        /// </summary>
        public const string CRURDT = "CRURDT";

        /// <summary>
        /// CRURAB.
        /// </summary>
        public const string CRURAB = "CRURAB";

        /// <summary>
        /// CRURAT.
        /// </summary>
        public const string CRURAT = "CRURAT";

        /// <summary>
        /// CRURRF.
        /// </summary>
        public const string CRURRF = "CRURRF";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRTORG.
        /// </summary>
        public const string CRTORG = "CRTORG";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRTDAY.
        /// </summary>
        public const string CRTDAY = "CRTDAY";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F49T01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRCRFTY", "CRCRFTY", JdeDataType.String, 22, true, true),
        new JdeField("CRNATIVE", "CRNATIVE", JdeDataType.String, 100, true, true),
        new JdeField("CRCNICL", "CRCNICL", JdeDataType.String, 100, true, true),
        new JdeField("CRURCD", "CRURCD", JdeDataType.String, 4),
        new JdeField("CRURDT", "CRURDT", JdeDataType.Numeric),
        new JdeField("CRURAB", "CRURAB", JdeDataType.Numeric),
        new JdeField("CRURAT", "CRURAT", JdeDataType.Numeric),
        new JdeField("CRURRF", "CRURRF", JdeDataType.String, 30),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRTORG", "CRTORG", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRTDAY", "CRTDAY", JdeDataType.Numeric),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T01_0", "Primary Key on CRCRFTY, CRNATIVE, CRCNICL", new[] { "CRCRFTY", "CRNATIVE", "CRCNICL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T01_2", "Index on CRCRFTY, CRCNICL, CRNATIVE", new[] { "CRCRFTY", "CRCNICL", "CRNATIVE" })
    };
}
