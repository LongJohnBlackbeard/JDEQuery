using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R121 - .
/// </summary>
public class F40R121 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRCUMID.
        /// </summary>
        public const string CRCUMID = "CRCUMID";

        /// <summary>
        /// CRDETYP.
        /// </summary>
        public const string CRDETYP = "CRDETYP";

        /// <summary>
        /// CRRQSJ.
        /// </summary>
        public const string CRRQSJ = "CRRQSJ";

        /// <summary>
        /// CRRSHT.
        /// </summary>
        public const string CRRSHT = "CRRSHT";

        /// <summary>
        /// CRCRQQYFM.
        /// </summary>
        public const string CRCRQQYFM = "CRCRQQYFM";

        /// <summary>
        /// CRUOM.
        /// </summary>
        public const string CRUOM = "CRUOM";

        /// <summary>
        /// CRURCD.
        /// </summary>
        public const string CRURCD = "CRURCD";

        /// <summary>
        /// CRURDT.
        /// </summary>
        public const string CRURDT = "CRURDT";

        /// <summary>
        /// CRURAT.
        /// </summary>
        public const string CRURAT = "CRURAT";

        /// <summary>
        /// CRURAB.
        /// </summary>
        public const string CRURAB = "CRURAB";

        /// <summary>
        /// CRURRF.
        /// </summary>
        public const string CRURRF = "CRURRF";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRTDAY.
        /// </summary>
        public const string CRTDAY = "CRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R121";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRCUMID", "CRCUMID", JdeDataType.Numeric, null, true, true),
        new JdeField("CRDETYP", "CRDETYP", JdeDataType.String, 4, true, true),
        new JdeField("CRRQSJ", "CRRQSJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CRRSHT", "CRRSHT", JdeDataType.Numeric, null, true, true),
        new JdeField("CRCRQQYFM", "CRCRQQYFM", JdeDataType.Numeric),
        new JdeField("CRUOM", "CRUOM", JdeDataType.String, 4),
        new JdeField("CRURCD", "CRURCD", JdeDataType.String, 4),
        new JdeField("CRURDT", "CRURDT", JdeDataType.Numeric),
        new JdeField("CRURAT", "CRURAT", JdeDataType.Numeric),
        new JdeField("CRURAB", "CRURAB", JdeDataType.Numeric),
        new JdeField("CRURRF", "CRURRF", JdeDataType.String, 30),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRTDAY", "CRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R121_0", "Primary Key on CRCUMID, CRDETYP, CRRQSJ, CRRSHT", new[] { "CRCUMID", "CRDETYP", "CRRQSJ", "CRRSHT" }, isUnique: true, isPrimaryKey: true)
    };
}
