using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L990 - .
/// </summary>
public class FF30L990 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MHDFCFGID.
        /// </summary>
        public const string MHDFCFGID = "MHDFCFGID";

        /// <summary>
        /// MHDFCFGDSC.
        /// </summary>
        public const string MHDFCFGDSC = "MHDFCFGDSC";

        /// <summary>
        /// MHFSCID.
        /// </summary>
        public const string MHFSCID = "MHFSCID";

        /// <summary>
        /// MHUSER.
        /// </summary>
        public const string MHUSER = "MHUSER";

        /// <summary>
        /// MHPID.
        /// </summary>
        public const string MHPID = "MHPID";

        /// <summary>
        /// MHMKEY.
        /// </summary>
        public const string MHMKEY = "MHMKEY";

        /// <summary>
        /// MHUUPMJ.
        /// </summary>
        public const string MHUUPMJ = "MHUUPMJ";

        /// <summary>
        /// MHURCD.
        /// </summary>
        public const string MHURCD = "MHURCD";

        /// <summary>
        /// MHURDT.
        /// </summary>
        public const string MHURDT = "MHURDT";

        /// <summary>
        /// MHURAT.
        /// </summary>
        public const string MHURAT = "MHURAT";

        /// <summary>
        /// MHURAB.
        /// </summary>
        public const string MHURAB = "MHURAB";

        /// <summary>
        /// MHURRF.
        /// </summary>
        public const string MHURRF = "MHURRF";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L990";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MHDFCFGID", "MHDFCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("MHDFCFGDSC", "MHDFCFGDSC", JdeDataType.String, 80),
        new JdeField("MHFSCID", "MHFSCID", JdeDataType.Numeric),
        new JdeField("MHUSER", "MHUSER", JdeDataType.String, 20),
        new JdeField("MHPID", "MHPID", JdeDataType.String, 20),
        new JdeField("MHMKEY", "MHMKEY", JdeDataType.String, 30),
        new JdeField("MHUUPMJ", "MHUUPMJ", JdeDataType.Date),
        new JdeField("MHURCD", "MHURCD", JdeDataType.String, 4),
        new JdeField("MHURDT", "MHURDT", JdeDataType.Numeric),
        new JdeField("MHURAT", "MHURAT", JdeDataType.Numeric),
        new JdeField("MHURAB", "MHURAB", JdeDataType.Numeric),
        new JdeField("MHURRF", "MHURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L990_0", "Primary Key on MHDFCFGID", new[] { "MHDFCFGID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L990_2", "Index on MHFSCID, MHDFCFGID", new[] { "MHFSCID", "MHDFCFGID" })
    };
}
