using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA23A - .
/// </summary>
public class F90CA23A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WPWPWID.
        /// </summary>
        public const string WPWPWID = "WPWPWID";

        /// <summary>
        /// WPUKID.
        /// </summary>
        public const string WPUKID = "WPUKID";

        /// <summary>
        /// WPSEQ.
        /// </summary>
        public const string WPSEQ = "WPSEQ";

        /// <summary>
        /// WPSSENAB.
        /// </summary>
        public const string WPSSENAB = "WPSSENAB";

        /// <summary>
        /// WPACTPRF.
        /// </summary>
        public const string WPACTPRF = "WPACTPRF";

        /// <summary>
        /// WPSSACTS.
        /// </summary>
        public const string WPSSACTS = "WPSSACTS";

        /// <summary>
        /// WPOBNM.
        /// </summary>
        public const string WPOBNM = "WPOBNM";

        /// <summary>
        /// WPFMNM.
        /// </summary>
        public const string WPFMNM = "WPFMNM";

        /// <summary>
        /// WPVERS.
        /// </summary>
        public const string WPVERS = "WPVERS";

        /// <summary>
        /// WPUSER.
        /// </summary>
        public const string WPUSER = "WPUSER";

        /// <summary>
        /// WPPID.
        /// </summary>
        public const string WPPID = "WPPID";

        /// <summary>
        /// WPJOBN.
        /// </summary>
        public const string WPJOBN = "WPJOBN";

        /// <summary>
        /// WPUPMJ.
        /// </summary>
        public const string WPUPMJ = "WPUPMJ";

        /// <summary>
        /// WPUPMT.
        /// </summary>
        public const string WPUPMT = "WPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA23A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WPWPWID", "WPWPWID", JdeDataType.Numeric),
        new JdeField("WPUKID", "WPUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WPSEQ", "WPSEQ", JdeDataType.Numeric),
        new JdeField("WPSSENAB", "WPSSENAB", JdeDataType.String, 2),
        new JdeField("WPACTPRF", "WPACTPRF", JdeDataType.String, 8),
        new JdeField("WPSSACTS", "WPSSACTS", JdeDataType.String, 20),
        new JdeField("WPOBNM", "WPOBNM", JdeDataType.String, 20),
        new JdeField("WPFMNM", "WPFMNM", JdeDataType.String, 20),
        new JdeField("WPVERS", "WPVERS", JdeDataType.String, 20),
        new JdeField("WPUSER", "WPUSER", JdeDataType.String, 20),
        new JdeField("WPPID", "WPPID", JdeDataType.String, 20),
        new JdeField("WPJOBN", "WPJOBN", JdeDataType.String, 20),
        new JdeField("WPUPMJ", "WPUPMJ", JdeDataType.Numeric),
        new JdeField("WPUPMT", "WPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA23A_0", "Primary Key on WPUKID", new[] { "WPUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA23A_4", "Index on WPWPWID", new[] { "WPWPWID" })
    };
}
