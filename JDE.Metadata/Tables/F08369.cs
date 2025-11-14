using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08369 - .
/// </summary>
public class F08369 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NCPLAN.
        /// </summary>
        public const string NCPLAN = "NCPLAN";

        /// <summary>
        /// NCTSTN.
        /// </summary>
        public const string NCTSTN = "NCTSTN";

        /// <summary>
        /// NCTSTY.
        /// </summary>
        public const string NCTSTY = "NCTSTY";

        /// <summary>
        /// NCAN8.
        /// </summary>
        public const string NCAN8 = "NCAN8";

        /// <summary>
        /// NCEGNO.
        /// </summary>
        public const string NCEGNO = "NCEGNO";

        /// <summary>
        /// NCCTVL.
        /// </summary>
        public const string NCCTVL = "NCCTVL";

        /// <summary>
        /// NCPID.
        /// </summary>
        public const string NCPID = "NCPID";

        /// <summary>
        /// NCUPMJ.
        /// </summary>
        public const string NCUPMJ = "NCUPMJ";

        /// <summary>
        /// NCUPMT.
        /// </summary>
        public const string NCUPMT = "NCUPMT";

        /// <summary>
        /// NCUSER.
        /// </summary>
        public const string NCUSER = "NCUSER";

        /// <summary>
        /// NCJOBN.
        /// </summary>
        public const string NCJOBN = "NCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08369";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCPLAN", "NCPLAN", JdeDataType.String, 16, true, true),
        new JdeField("NCTSTN", "NCTSTN", JdeDataType.String, 16, true, true),
        new JdeField("NCTSTY", "NCTSTY", JdeDataType.Numeric, null, true, true),
        new JdeField("NCAN8", "NCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NCEGNO", "NCEGNO", JdeDataType.String, 8),
        new JdeField("NCCTVL", "NCCTVL", JdeDataType.String, 2),
        new JdeField("NCPID", "NCPID", JdeDataType.String, 20),
        new JdeField("NCUPMJ", "NCUPMJ", JdeDataType.Numeric),
        new JdeField("NCUPMT", "NCUPMT", JdeDataType.Numeric),
        new JdeField("NCUSER", "NCUSER", JdeDataType.String, 20),
        new JdeField("NCJOBN", "NCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08369_0", "Primary Key on NCPLAN, NCTSTN, NCTSTY, NCAN8", new[] { "NCPLAN", "NCTSTN", "NCTSTY", "NCAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
