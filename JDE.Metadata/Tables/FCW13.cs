using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW13 - .
/// </summary>
public class FCW13 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WLITM.
        /// </summary>
        public const string WLITM = "WLITM";

        /// <summary>
        /// WLEV01.
        /// </summary>
        public const string WLEV01 = "WLEV01";

        /// <summary>
        /// WLMCU.
        /// </summary>
        public const string WLMCU = "WLMCU";

        /// <summary>
        /// WLLOCN.
        /// </summary>
        public const string WLLOCN = "WLLOCN";

        /// <summary>
        /// WLLOTN.
        /// </summary>
        public const string WLLOTN = "WLLOTN";

        /// <summary>
        /// WLPBIN.
        /// </summary>
        public const string WLPBIN = "WLPBIN";

        /// <summary>
        /// WLGLPT.
        /// </summary>
        public const string WLGLPT = "WLGLPT";

        /// <summary>
        /// WLLOTS.
        /// </summary>
        public const string WLLOTS = "WLLOTS";

        /// <summary>
        /// WLNCDJ.
        /// </summary>
        public const string WLNCDJ = "WLNCDJ";

        /// <summary>
        /// WLCHDF.
        /// </summary>
        public const string WLCHDF = "WLCHDF";

        /// <summary>
        /// WLWPDF.
        /// </summary>
        public const string WLWPDF = "WLWPDF";

        /// <summary>
        /// WLCFGSID.
        /// </summary>
        public const string WLCFGSID = "WLCFGSID";
    }

    /// <inheritdoc />
    public override string TableName => "FCW13";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WLITM", "WLITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WLEV01", "WLEV01", JdeDataType.String, 2, true, true),
        new JdeField("WLMCU", "WLMCU", JdeDataType.String, 24, true, true),
        new JdeField("WLLOCN", "WLLOCN", JdeDataType.String, 40, true, true),
        new JdeField("WLLOTN", "WLLOTN", JdeDataType.String, 60, true, true),
        new JdeField("WLPBIN", "WLPBIN", JdeDataType.String, 2),
        new JdeField("WLGLPT", "WLGLPT", JdeDataType.String, 8),
        new JdeField("WLLOTS", "WLLOTS", JdeDataType.String, 2),
        new JdeField("WLNCDJ", "WLNCDJ", JdeDataType.Numeric),
        new JdeField("WLCHDF", "WLCHDF", JdeDataType.String, 2),
        new JdeField("WLWPDF", "WLWPDF", JdeDataType.String, 2),
        new JdeField("WLCFGSID", "WLCFGSID", JdeDataType.String, 64)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW13_0", "Primary Key on WLITM, WLEV01, WLMCU, WLLOCN, WLLOTN", new[] { "WLITM", "WLEV01", "WLMCU", "WLLOCN", "WLLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
