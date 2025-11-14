using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51X0911 - .
/// </summary>
public class F51X0911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ALUSER.
        /// </summary>
        public const string ALUSER = "ALUSER";

        /// <summary>
        /// ALJOBS.
        /// </summary>
        public const string ALJOBS = "ALJOBS";

        /// <summary>
        /// ALMCU.
        /// </summary>
        public const string ALMCU = "ALMCU";

        /// <summary>
        /// ALAID.
        /// </summary>
        public const string ALAID = "ALAID";

        /// <summary>
        /// ALOBJ.
        /// </summary>
        public const string ALOBJ = "ALOBJ";

        /// <summary>
        /// ALSUB.
        /// </summary>
        public const string ALSUB = "ALSUB";

        /// <summary>
        /// ALLT.
        /// </summary>
        public const string ALLT = "ALLT";

        /// <summary>
        /// AL51XDRF.
        /// </summary>
        public const string AL51XDRF = "AL51XDRF";

        /// <summary>
        /// ALSBL.
        /// </summary>
        public const string ALSBL = "ALSBL";

        /// <summary>
        /// ALSBLT.
        /// </summary>
        public const string ALSBLT = "ALSBLT";

        /// <summary>
        /// ALBCRC.
        /// </summary>
        public const string ALBCRC = "ALBCRC";

        /// <summary>
        /// ALAA.
        /// </summary>
        public const string ALAA = "ALAA";

        /// <summary>
        /// ALU.
        /// </summary>
        public const string ALU = "ALU";

        /// <summary>
        /// AL51XAOC.
        /// </summary>
        public const string AL51XAOC = "AL51XAOC";
    }

    /// <inheritdoc />
    public override string TableName => "F51X0911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ALUSER", "ALUSER", JdeDataType.String, 20, true, true),
        new JdeField("ALJOBS", "ALJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ALMCU", "ALMCU", JdeDataType.String, 24, true, true),
        new JdeField("ALAID", "ALAID", JdeDataType.String, 16, true, true),
        new JdeField("ALOBJ", "ALOBJ", JdeDataType.String, 12),
        new JdeField("ALSUB", "ALSUB", JdeDataType.String, 16),
        new JdeField("ALLT", "ALLT", JdeDataType.String, 4, true, true),
        new JdeField("AL51XDRF", "AL51XDRF", JdeDataType.String, 2, true, true),
        new JdeField("ALSBL", "ALSBL", JdeDataType.String, 16),
        new JdeField("ALSBLT", "ALSBLT", JdeDataType.String, 2),
        new JdeField("ALBCRC", "ALBCRC", JdeDataType.String, 6),
        new JdeField("ALAA", "ALAA", JdeDataType.Numeric),
        new JdeField("ALU", "ALU", JdeDataType.Numeric),
        new JdeField("AL51XAOC", "AL51XAOC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51X0911_0", "Primary Key on ALUSER, ALJOBS, ALMCU, ALAID, ALLT, AL51XDRF", new[] { "ALUSER", "ALJOBS", "ALMCU", "ALAID", "ALLT", "AL51XDRF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F51X0911_2", "Index on ALAID", new[] { "ALAID" })
    };
}
