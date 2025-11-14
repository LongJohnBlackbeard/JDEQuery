using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09305 - .
/// </summary>
public class F09305 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GRDTAI.
        /// </summary>
        public const string GRDTAI = "GRDTAI";

        /// <summary>
        /// GROBNM.
        /// </summary>
        public const string GROBNM = "GROBNM";

        /// <summary>
        /// GRUSER.
        /// </summary>
        public const string GRUSER = "GRUSER";

        /// <summary>
        /// GRPID.
        /// </summary>
        public const string GRPID = "GRPID";

        /// <summary>
        /// GRJOBN.
        /// </summary>
        public const string GRJOBN = "GRJOBN";

        /// <summary>
        /// GRUPMJ.
        /// </summary>
        public const string GRUPMJ = "GRUPMJ";

        /// <summary>
        /// GRUPMT.
        /// </summary>
        public const string GRUPMT = "GRUPMT";

        /// <summary>
        /// GRDRDF.
        /// </summary>
        public const string GRDRDF = "GRDRDF";
    }

    /// <inheritdoc />
    public override string TableName => "F09305";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GRDTAI", "GRDTAI", JdeDataType.String, 20, true, true),
        new JdeField("GROBNM", "GROBNM", JdeDataType.String, 20, true, true),
        new JdeField("GRUSER", "GRUSER", JdeDataType.String, 20),
        new JdeField("GRPID", "GRPID", JdeDataType.String, 20),
        new JdeField("GRJOBN", "GRJOBN", JdeDataType.String, 20),
        new JdeField("GRUPMJ", "GRUPMJ", JdeDataType.Numeric),
        new JdeField("GRUPMT", "GRUPMT", JdeDataType.Numeric),
        new JdeField("GRDRDF", "GRDRDF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09305_0", "Primary Key on GRDTAI, GROBNM", new[] { "GRDTAI", "GROBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
