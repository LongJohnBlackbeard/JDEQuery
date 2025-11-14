using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08397 - .
/// </summary>
public class F08397 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HYTSTN.
        /// </summary>
        public const string HYTSTN = "HYTSTN";

        /// <summary>
        /// HYTSTY.
        /// </summary>
        public const string HYTSTY = "HYTSTY";

        /// <summary>
        /// HYLIN.
        /// </summary>
        public const string HYLIN = "HYLIN";

        /// <summary>
        /// HYAOR1.
        /// </summary>
        public const string HYAOR1 = "HYAOR1";

        /// <summary>
        /// HYCMPL.
        /// </summary>
        public const string HYCMPL = "HYCMPL";

        /// <summary>
        /// HYPTCL.
        /// </summary>
        public const string HYPTCL = "HYPTCL";

        /// <summary>
        /// HYTPP.
        /// </summary>
        public const string HYTPP = "HYTPP";

        /// <summary>
        /// HYTPM.
        /// </summary>
        public const string HYTPM = "HYTPM";

        /// <summary>
        /// HYCTNO.
        /// </summary>
        public const string HYCTNO = "HYCTNO";

        /// <summary>
        /// HYCTVL.
        /// </summary>
        public const string HYCTVL = "HYCTVL";
    }

    /// <inheritdoc />
    public override string TableName => "F08397";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HYTSTN", "HYTSTN", JdeDataType.String, 16, true, true),
        new JdeField("HYTSTY", "HYTSTY", JdeDataType.Numeric, null, true, true),
        new JdeField("HYLIN", "HYLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("HYAOR1", "HYAOR1", JdeDataType.String, 6),
        new JdeField("HYCMPL", "HYCMPL", JdeDataType.Numeric),
        new JdeField("HYPTCL", "HYPTCL", JdeDataType.String, 8),
        new JdeField("HYTPP", "HYTPP", JdeDataType.Numeric),
        new JdeField("HYTPM", "HYTPM", JdeDataType.String, 2),
        new JdeField("HYCTNO", "HYCTNO", JdeDataType.Numeric),
        new JdeField("HYCTVL", "HYCTVL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08397_0", "Primary Key on HYTSTN, HYTSTY, HYLIN", new[] { "HYTSTN", "HYTSTY", "HYLIN" }, isUnique: true, isPrimaryKey: true)
    };
}
