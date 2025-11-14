using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085515 - .
/// </summary>
public class F085515 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WPPROCVER.
        /// </summary>
        public const string WPPROCVER = "WPPROCVER";

        /// <summary>
        /// WPPROCNAME.
        /// </summary>
        public const string WPPROCNAME = "WPPROCNAME";

        /// <summary>
        /// WPWFOBNM.
        /// </summary>
        public const string WPWFOBNM = "WPWFOBNM";

        /// <summary>
        /// WPEECD.
        /// </summary>
        public const string WPEECD = "WPEECD";

        /// <summary>
        /// WPPID.
        /// </summary>
        public const string WPPID = "WPPID";

        /// <summary>
        /// WPUPMJ.
        /// </summary>
        public const string WPUPMJ = "WPUPMJ";

        /// <summary>
        /// WPUPMT.
        /// </summary>
        public const string WPUPMT = "WPUPMT";

        /// <summary>
        /// WPUSER.
        /// </summary>
        public const string WPUSER = "WPUSER";

        /// <summary>
        /// WPJOBN.
        /// </summary>
        public const string WPJOBN = "WPJOBN";

        /// <summary>
        /// WPMBDS.
        /// </summary>
        public const string WPMBDS = "WPMBDS";

        /// <summary>
        /// WPPRCENBL.
        /// </summary>
        public const string WPPRCENBL = "WPPRCENBL";
    }

    /// <inheritdoc />
    public override string TableName => "F085515";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WPPROCVER", "WPPROCVER", JdeDataType.Numeric),
        new JdeField("WPPROCNAME", "WPPROCNAME", JdeDataType.String, 20),
        new JdeField("WPWFOBNM", "WPWFOBNM", JdeDataType.String, 20, true, true),
        new JdeField("WPEECD", "WPEECD", JdeDataType.String, 6, true, true),
        new JdeField("WPPID", "WPPID", JdeDataType.String, 20),
        new JdeField("WPUPMJ", "WPUPMJ", JdeDataType.Numeric),
        new JdeField("WPUPMT", "WPUPMT", JdeDataType.Numeric),
        new JdeField("WPUSER", "WPUSER", JdeDataType.String, 20),
        new JdeField("WPJOBN", "WPJOBN", JdeDataType.String, 20),
        new JdeField("WPMBDS", "WPMBDS", JdeDataType.String, 4),
        new JdeField("WPPRCENBL", "WPPRCENBL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085515_0", "Primary Key on WPWFOBNM, WPEECD", new[] { "WPWFOBNM", "WPEECD" }, isUnique: true, isPrimaryKey: true)
    };
}
