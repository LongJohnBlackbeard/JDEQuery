using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41UI003 - .
/// </summary>
public class F41UI003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AACTID.
        /// </summary>
        public const string AACTID = "AACTID";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AATDAY.
        /// </summary>
        public const string AATDAY = "AATDAY";

        /// <summary>
        /// AAITM.
        /// </summary>
        public const string AAITM = "AAITM";

        /// <summary>
        /// AAMCU.
        /// </summary>
        public const string AAMCU = "AAMCU";

        /// <summary>
        /// AAUITM.
        /// </summary>
        public const string AAUITM = "AAUITM";

        /// <summary>
        /// AADSC1.
        /// </summary>
        public const string AADSC1 = "AADSC1";

        /// <summary>
        /// AAABC0.
        /// </summary>
        public const string AAABC0 = "AAABC0";

        /// <summary>
        /// AAECST.
        /// </summary>
        public const string AAECST = "AAECST";

        /// <summary>
        /// AAPABC.
        /// </summary>
        public const string AAPABC = "AAPABC";
    }

    /// <inheritdoc />
    public override string TableName => "F41UI003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AACTID", "AACTID", JdeDataType.String, 30, true, true),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("AATDAY", "AATDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("AAITM", "AAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("AAMCU", "AAMCU", JdeDataType.String, 24, true, true),
        new JdeField("AAUITM", "AAUITM", JdeDataType.String, 52),
        new JdeField("AADSC1", "AADSC1", JdeDataType.String, 60),
        new JdeField("AAABC0", "AAABC0", JdeDataType.String, 2),
        new JdeField("AAECST", "AAECST", JdeDataType.Numeric),
        new JdeField("AAPABC", "AAPABC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41UI003_0", "Primary Key on AACTID, AAUPMJ, AATDAY, AAMCU, AAITM", new[] { "AACTID", "AAUPMJ", "AATDAY", "AAMCU", "AAITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41UI003_2", "Index on AACTID, AAUPMJ, AATDAY, AAMCU, AAPABC, AAUITM", new[] { "AACTID", "AAUPMJ", "AATDAY", "AAMCU", "AAPABC", "AAUITM" })
    };
}
