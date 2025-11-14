using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H73W2 - .
/// </summary>
public class F44H73W2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BGJOBS.
        /// </summary>
        public const string BGJOBS = "BGJOBS";

        /// <summary>
        /// BGMCU.
        /// </summary>
        public const string BGMCU = "BGMCU";

        /// <summary>
        /// BGOBJ.
        /// </summary>
        public const string BGOBJ = "BGOBJ";

        /// <summary>
        /// BGSUB.
        /// </summary>
        public const string BGSUB = "BGSUB";

        /// <summary>
        /// BGSBL.
        /// </summary>
        public const string BGSBL = "BGSBL";

        /// <summary>
        /// BGSBLT.
        /// </summary>
        public const string BGSBLT = "BGSBLT";

        /// <summary>
        /// BGAA.
        /// </summary>
        public const string BGAA = "BGAA";

        /// <summary>
        /// BGU.
        /// </summary>
        public const string BGU = "BGU";

        /// <summary>
        /// BGHBPFLG1.
        /// </summary>
        public const string BGHBPFLG1 = "BGHBPFLG1";

        /// <summary>
        /// BGLSWERR.
        /// </summary>
        public const string BGLSWERR = "BGLSWERR";

        /// <summary>
        /// BGHBMCUS.
        /// </summary>
        public const string BGHBMCUS = "BGHBMCUS";

        /// <summary>
        /// BGHBAREA.
        /// </summary>
        public const string BGHBAREA = "BGHBAREA";

        /// <summary>
        /// BGHBLOT.
        /// </summary>
        public const string BGHBLOT = "BGHBLOT";

        /// <summary>
        /// BGAID.
        /// </summary>
        public const string BGAID = "BGAID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H73W2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BGJOBS", "BGJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("BGMCU", "BGMCU", JdeDataType.String, 24, true, true),
        new JdeField("BGOBJ", "BGOBJ", JdeDataType.String, 12, true, true),
        new JdeField("BGSUB", "BGSUB", JdeDataType.String, 16, true, true),
        new JdeField("BGSBL", "BGSBL", JdeDataType.String, 16, true, true),
        new JdeField("BGSBLT", "BGSBLT", JdeDataType.String, 2),
        new JdeField("BGAA", "BGAA", JdeDataType.Numeric),
        new JdeField("BGU", "BGU", JdeDataType.Numeric),
        new JdeField("BGHBPFLG1", "BGHBPFLG1", JdeDataType.String, 2),
        new JdeField("BGLSWERR", "BGLSWERR", JdeDataType.String, 20),
        new JdeField("BGHBMCUS", "BGHBMCUS", JdeDataType.String, 24),
        new JdeField("BGHBAREA", "BGHBAREA", JdeDataType.String, 6),
        new JdeField("BGHBLOT", "BGHBLOT", JdeDataType.String, 8),
        new JdeField("BGAID", "BGAID", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H73W2_0", "Primary Key on BGJOBS, BGMCU, BGOBJ, BGSUB, BGSBL", new[] { "BGJOBS", "BGMCU", "BGOBJ", "BGSUB", "BGSBL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H73W2_2", "Index on BGJOBS, BGHBMCUS, BGHBLOT", new[] { "BGJOBS", "BGHBMCUS", "BGHBLOT" })
    };
}
