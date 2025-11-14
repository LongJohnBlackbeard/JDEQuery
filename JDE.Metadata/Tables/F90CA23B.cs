using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA23B - .
/// </summary>
public class F90CA23B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MMUK01.
        /// </summary>
        public const string MMUK01 = "MMUK01";

        /// <summary>
        /// MMCRMMMLCT.
        /// </summary>
        public const string MMCRMMMLCT = "MMCRMMMLCT";

        /// <summary>
        /// MMCRMMMLCET.
        /// </summary>
        public const string MMCRMMMLCET = "MMCRMMMLCET";

        /// <summary>
        /// MMMMGE.
        /// </summary>
        public const string MMMMGE = "MMMMGE";

        /// <summary>
        /// MMCRMMMTID.
        /// </summary>
        public const string MMCRMMMTID = "MMCRMMMTID";

        /// <summary>
        /// MMMMDTP.
        /// </summary>
        public const string MMMMDTP = "MMMMDTP";

        /// <summary>
        /// MMMMELTID.
        /// </summary>
        public const string MMMMELTID = "MMMMELTID";

        /// <summary>
        /// MMMMETL.
        /// </summary>
        public const string MMMMETL = "MMMMETL";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA23B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MMUK01", "MMUK01", JdeDataType.Numeric, null, true, true),
        new JdeField("MMCRMMMLCT", "MMCRMMMLCT", JdeDataType.Numeric),
        new JdeField("MMCRMMMLCET", "MMCRMMMLCET", JdeDataType.Numeric),
        new JdeField("MMMMGE", "MMMMGE", JdeDataType.Numeric),
        new JdeField("MMCRMMMTID", "MMCRMMMTID", JdeDataType.String, 20),
        new JdeField("MMMMDTP", "MMMMDTP", JdeDataType.String, 512),
        new JdeField("MMMMELTID", "MMMMELTID", JdeDataType.String, 20),
        new JdeField("MMMMETL", "MMMMETL", JdeDataType.String, 512)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA23B_0", "Primary Key on MMUK01", new[] { "MMUK01" }, isUnique: true, isPrimaryKey: true)
    };
}
