using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F980014W - .
/// </summary>
public class F980014W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MMOBNM.
        /// </summary>
        public const string MMOBNM = "MMOBNM";

        /// <summary>
        /// MMDESC.
        /// </summary>
        public const string MMDESC = "MMDESC";

        /// <summary>
        /// MMUSER.
        /// </summary>
        public const string MMUSER = "MMUSER";

        /// <summary>
        /// MMDM.
        /// </summary>
        public const string MMDM = "MMDM";

        /// <summary>
        /// MMDSON.
        /// </summary>
        public const string MMDSON = "MMDSON";

        /// <summary>
        /// MMQUNAM.
        /// </summary>
        public const string MMQUNAM = "MMQUNAM";

        /// <summary>
        /// MMMOFILE.
        /// </summary>
        public const string MMMOFILE = "MMMOFILE";

        /// <summary>
        /// MMMMDRN.
        /// </summary>
        public const string MMMMDRN = "MMMMDRN";

        /// <summary>
        /// MMMMQUE.
        /// </summary>
        public const string MMMMQUE = "MMMMQUE";

        /// <summary>
        /// MMMMDS.
        /// </summary>
        public const string MMMMDS = "MMMMDS";
    }

    /// <inheritdoc />
    public override string TableName => "F980014W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MMOBNM", "MMOBNM", JdeDataType.String, 20, true, true),
        new JdeField("MMDESC", "MMDESC", JdeDataType.String, 60),
        new JdeField("MMUSER", "MMUSER", JdeDataType.String, 20),
        new JdeField("MMDM", "MMDM", JdeDataType.Numeric),
        new JdeField("MMDSON", "MMDSON", JdeDataType.String, 20),
        new JdeField("MMQUNAM", "MMQUNAM", JdeDataType.String, 60),
        new JdeField("MMMOFILE", "MMMOFILE", JdeDataType.String, 64),
        new JdeField("MMMMDRN", "MMMMDRN", JdeDataType.Numeric),
        new JdeField("MMMMQUE", "MMMMQUE", JdeDataType.String, 60),
        new JdeField("MMMMDS", "MMMMDS", JdeDataType.String)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F980014W_0", "Primary Key on MMOBNM", new[] { "MMOBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
