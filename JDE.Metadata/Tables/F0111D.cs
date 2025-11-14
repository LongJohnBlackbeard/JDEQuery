using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0111D - .
/// </summary>
public class F0111D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WAAN8.
        /// </summary>
        public const string WAAN8 = "WAAN8";

        /// <summary>
        /// WALNGP.
        /// </summary>
        public const string WALNGP = "WALNGP";

        /// <summary>
        /// WAIDLN.
        /// </summary>
        public const string WAIDLN = "WAIDLN";

        /// <summary>
        /// WAMLNM.
        /// </summary>
        public const string WAMLNM = "WAMLNM";

        /// <summary>
        /// WAMLN1.
        /// </summary>
        public const string WAMLN1 = "WAMLN1";

        /// <summary>
        /// WAUPMT.
        /// </summary>
        public const string WAUPMT = "WAUPMT";

        /// <summary>
        /// WAUPMJ.
        /// </summary>
        public const string WAUPMJ = "WAUPMJ";

        /// <summary>
        /// WAUSER.
        /// </summary>
        public const string WAUSER = "WAUSER";

        /// <summary>
        /// WAPID.
        /// </summary>
        public const string WAPID = "WAPID";

        /// <summary>
        /// WAJOBN.
        /// </summary>
        public const string WAJOBN = "WAJOBN";

        /// <summary>
        /// WAFUMATH3.
        /// </summary>
        public const string WAFUMATH3 = "WAFUMATH3";

        /// <summary>
        /// WAFUDATE3.
        /// </summary>
        public const string WAFUDATE3 = "WAFUDATE3";

        /// <summary>
        /// WAFTCHAR3.
        /// </summary>
        public const string WAFTCHAR3 = "WAFTCHAR3";

        /// <summary>
        /// WAFUTUSTR3.
        /// </summary>
        public const string WAFUTUSTR3 = "WAFUTUSTR3";
    }

    /// <inheritdoc />
    public override string TableName => "F0111D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WAAN8", "WAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WALNGP", "WALNGP", JdeDataType.String, 4, true, true),
        new JdeField("WAIDLN", "WAIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("WAMLNM", "WAMLNM", JdeDataType.String, 80),
        new JdeField("WAMLN1", "WAMLN1", JdeDataType.String, 80),
        new JdeField("WAUPMT", "WAUPMT", JdeDataType.Numeric),
        new JdeField("WAUPMJ", "WAUPMJ", JdeDataType.Numeric),
        new JdeField("WAUSER", "WAUSER", JdeDataType.String, 20),
        new JdeField("WAPID", "WAPID", JdeDataType.String, 20),
        new JdeField("WAJOBN", "WAJOBN", JdeDataType.String, 20),
        new JdeField("WAFUMATH3", "WAFUMATH3", JdeDataType.Numeric),
        new JdeField("WAFUDATE3", "WAFUDATE3", JdeDataType.Numeric),
        new JdeField("WAFTCHAR3", "WAFTCHAR3", JdeDataType.String, 2),
        new JdeField("WAFUTUSTR3", "WAFUTUSTR3", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0111D_0", "Primary Key on WAAN8, WALNGP, WAIDLN", new[] { "WAAN8", "WALNGP", "WAIDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
