using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F060117 - .
/// </summary>
public class F060117 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YAAN8.
        /// </summary>
        public const string YAAN8 = "YAAN8";

        /// <summary>
        /// YANAMP.
        /// </summary>
        public const string YANAMP = "YANAMP";

        /// <summary>
        /// YAMALP.
        /// </summary>
        public const string YAMALP = "YAMALP";

        /// <summary>
        /// YAESAL.
        /// </summary>
        public const string YAESAL = "YAESAL";

        /// <summary>
        /// YAESMD.
        /// </summary>
        public const string YAESMD = "YAESMD";

        /// <summary>
        /// YAEXSZ.
        /// </summary>
        public const string YAEXSZ = "YAEXSZ";

        /// <summary>
        /// YALNGP.
        /// </summary>
        public const string YALNGP = "YALNGP";

        /// <summary>
        /// YAALRN.
        /// </summary>
        public const string YAALRN = "YAALRN";

        /// <summary>
        /// YASALU.
        /// </summary>
        public const string YASALU = "YASALU";

        /// <summary>
        /// YASUFF.
        /// </summary>
        public const string YASUFF = "YASUFF";

        /// <summary>
        /// YAPRNM.
        /// </summary>
        public const string YAPRNM = "YAPRNM";

        /// <summary>
        /// YAADDN.
        /// </summary>
        public const string YAADDN = "YAADDN";

        /// <summary>
        /// YACRCD.
        /// </summary>
        public const string YACRCD = "YACRCD";

        /// <summary>
        /// YACENC.
        /// </summary>
        public const string YACENC = "YACENC";

        /// <summary>
        /// YACECM.
        /// </summary>
        public const string YACECM = "YACECM";

        /// <summary>
        /// YACESI.
        /// </summary>
        public const string YACESI = "YACESI";
    }

    /// <inheritdoc />
    public override string TableName => "F060117";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YAAN8", "YAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YANAMP", "YANAMP", JdeDataType.String, 100),
        new JdeField("YAMALP", "YAMALP", JdeDataType.String, 80),
        new JdeField("YAESAL", "YAESAL", JdeDataType.Numeric),
        new JdeField("YAESMD", "YAESMD", JdeDataType.String, 2),
        new JdeField("YAEXSZ", "YAEXSZ", JdeDataType.Numeric),
        new JdeField("YALNGP", "YALNGP", JdeDataType.String, 4),
        new JdeField("YAALRN", "YAALRN", JdeDataType.String, 20),
        new JdeField("YASALU", "YASALU", JdeDataType.String, 10),
        new JdeField("YASUFF", "YASUFF", JdeDataType.String, 10),
        new JdeField("YAPRNM", "YAPRNM", JdeDataType.String, 40),
        new JdeField("YAADDN", "YAADDN", JdeDataType.String, 40),
        new JdeField("YACRCD", "YACRCD", JdeDataType.String, 6),
        new JdeField("YACENC", "YACENC", JdeDataType.String, 8),
        new JdeField("YACECM", "YACECM", JdeDataType.String, 4),
        new JdeField("YACESI", "YACESI", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F060117_0", "Primary Key on YAAN8", new[] { "YAAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
