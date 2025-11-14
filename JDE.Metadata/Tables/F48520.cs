using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48520 - .
/// </summary>
public class F48520 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AEDGL.
        /// </summary>
        public const string AEDGL = "AEDGL";

        /// <summary>
        /// AEAN8.
        /// </summary>
        public const string AEAN8 = "AEAN8";

        /// <summary>
        /// AEMCU.
        /// </summary>
        public const string AEMCU = "AEMCU";

        /// <summary>
        /// AEOBJ.
        /// </summary>
        public const string AEOBJ = "AEOBJ";

        /// <summary>
        /// AESUB.
        /// </summary>
        public const string AESUB = "AESUB";

        /// <summary>
        /// AEDOCO.
        /// </summary>
        public const string AEDOCO = "AEDOCO";

        /// <summary>
        /// AEDCTO.
        /// </summary>
        public const string AEDCTO = "AEDCTO";

        /// <summary>
        /// AEKCOO.
        /// </summary>
        public const string AEKCOO = "AEKCOO";

        /// <summary>
        /// AECOCH.
        /// </summary>
        public const string AECOCH = "AECOCH";

        /// <summary>
        /// AELNID.
        /// </summary>
        public const string AELNID = "AELNID";

        /// <summary>
        /// AECCOD.
        /// </summary>
        public const string AECCOD = "AECCOD";

        /// <summary>
        /// AECRCD.
        /// </summary>
        public const string AECRCD = "AECRCD";

        /// <summary>
        /// AECRCF.
        /// </summary>
        public const string AECRCF = "AECRCF";

        /// <summary>
        /// AEITOL.
        /// </summary>
        public const string AEITOL = "AEITOL";

        /// <summary>
        /// AEITXA.
        /// </summary>
        public const string AEITXA = "AEITXA";

        /// <summary>
        /// AEITAM.
        /// </summary>
        public const string AEITAM = "AEITAM";

        /// <summary>
        /// AEIDSC.
        /// </summary>
        public const string AEIDSC = "AEIDSC";

        /// <summary>
        /// AECITL.
        /// </summary>
        public const string AECITL = "AECITL";

        /// <summary>
        /// AECITA.
        /// </summary>
        public const string AECITA = "AECITA";

        /// <summary>
        /// AECITX.
        /// </summary>
        public const string AECITX = "AECITX";

        /// <summary>
        /// AECIDS.
        /// </summary>
        public const string AECIDS = "AECIDS";

        /// <summary>
        /// AEU.
        /// </summary>
        public const string AEU = "AEU";

        /// <summary>
        /// AEAA.
        /// </summary>
        public const string AEAA = "AEAA";
    }

    /// <inheritdoc />
    public override string TableName => "F48520";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AEDGL", "AEDGL", JdeDataType.Numeric, null, true, true),
        new JdeField("AEAN8", "AEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AEMCU", "AEMCU", JdeDataType.String, 24, true, true),
        new JdeField("AEOBJ", "AEOBJ", JdeDataType.String, 12, true, true),
        new JdeField("AESUB", "AESUB", JdeDataType.String, 16, true, true),
        new JdeField("AEDOCO", "AEDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("AEDCTO", "AEDCTO", JdeDataType.String, 4, true, true),
        new JdeField("AEKCOO", "AEKCOO", JdeDataType.String, 10, true, true),
        new JdeField("AECOCH", "AECOCH", JdeDataType.String, 6, true, true),
        new JdeField("AELNID", "AELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("AECCOD", "AECCOD", JdeDataType.String, 10, true, true),
        new JdeField("AECRCD", "AECRCD", JdeDataType.String, 6, true, true),
        new JdeField("AECRCF", "AECRCF", JdeDataType.String, 6, true, true),
        new JdeField("AEITOL", "AEITOL", JdeDataType.Numeric),
        new JdeField("AEITXA", "AEITXA", JdeDataType.Numeric),
        new JdeField("AEITAM", "AEITAM", JdeDataType.Numeric),
        new JdeField("AEIDSC", "AEIDSC", JdeDataType.Numeric),
        new JdeField("AECITL", "AECITL", JdeDataType.Numeric),
        new JdeField("AECITA", "AECITA", JdeDataType.Numeric),
        new JdeField("AECITX", "AECITX", JdeDataType.Numeric),
        new JdeField("AECIDS", "AECIDS", JdeDataType.Numeric),
        new JdeField("AEU", "AEU", JdeDataType.Numeric),
        new JdeField("AEAA", "AEAA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48520_0", "Primary Key on AEDOCO, AEDCTO, AEKCOO, AECOCH, AELNID, AEAN8, AEMCU, AEOBJ, AESUB, AECCOD, AECRCD, AECRCF, AEDGL", new[] { "AEDOCO", "AEDCTO", "AEKCOO", "AECOCH", "AELNID", "AEAN8", "AEMCU", "AEOBJ", "AESUB", "AECCOD", "AECRCD", "AECRCF", "AEDGL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48520_10", "Index on AEMCU, AEOBJ, AESUB, AEAN8, AEDOCO, AEDCTO, AEKCOO, AECOCH, AELNID, AECCOD, AECRCD, AECRCF, SYS_NC00024$", new[] { "AEMCU", "AEOBJ", "AESUB", "AEAN8", "AEDOCO", "AEDCTO", "AEKCOO", "AECOCH", "AELNID", "AECCOD", "AECRCD", "AECRCF", "SYS_NC00024$" }),
        new JdeIndex("F48520_11", "Index on AEAN8, AEMCU, AEOBJ, AESUB, AEDOCO, AEDCTO, AEKCOO, AECOCH, AELNID, AECCOD, AECRCD, AECRCF, SYS_NC00024$", new[] { "AEAN8", "AEMCU", "AEOBJ", "AESUB", "AEDOCO", "AEDCTO", "AEKCOO", "AECOCH", "AELNID", "AECCOD", "AECRCD", "AECRCF", "SYS_NC00024$" }),
        new JdeIndex("F48520_2", "Index on AEDOCO, AEDCTO, AEKCOO, AECOCH, AELNID, AEMCU, AEOBJ, AESUB, AEAN8, AECCOD, AECRCD, AECRCF, AEDGL", new[] { "AEDOCO", "AEDCTO", "AEKCOO", "AECOCH", "AELNID", "AEMCU", "AEOBJ", "AESUB", "AEAN8", "AECCOD", "AECRCD", "AECRCF", "AEDGL" }),
        new JdeIndex("F48520_4", "Index on AEMCU, AESUB, AEOBJ, AEAN8, AEDOCO, AEDCTO, AEKCOO, AECOCH, AELNID, AECCOD, AECRCD, AECRCF, AEDGL", new[] { "AEMCU", "AESUB", "AEOBJ", "AEAN8", "AEDOCO", "AEDCTO", "AEKCOO", "AECOCH", "AELNID", "AECCOD", "AECRCD", "AECRCF", "AEDGL" }),
        new JdeIndex("F48520_5", "Index on AEMCU, AEOBJ, AESUB, AEAN8, AEDOCO, AEDCTO, AEKCOO, AECOCH, AELNID, AECCOD, AECRCD, AECRCF, AEDGL", new[] { "AEMCU", "AEOBJ", "AESUB", "AEAN8", "AEDOCO", "AEDCTO", "AEKCOO", "AECOCH", "AELNID", "AECCOD", "AECRCD", "AECRCF", "AEDGL" }),
        new JdeIndex("F48520_6", "Index on AEAN8, AEMCU, AEOBJ, AESUB, AEDOCO, AEDCTO, AEKCOO, AECOCH, AELNID, AECCOD, AECRCD, AECRCF, AEDGL", new[] { "AEAN8", "AEMCU", "AEOBJ", "AESUB", "AEDOCO", "AEDCTO", "AEKCOO", "AECOCH", "AELNID", "AECCOD", "AECRCD", "AECRCF", "AEDGL" }),
        new JdeIndex("F48520_7", "Index on AEDOCO, AEDCTO, AEKCOO, AECOCH, AELNID, AEAN8, AEMCU, AEOBJ, AESUB, AECCOD, AECRCD, AECRCF, SYS_NC00024$", new[] { "AEDOCO", "AEDCTO", "AEKCOO", "AECOCH", "AELNID", "AEAN8", "AEMCU", "AEOBJ", "AESUB", "AECCOD", "AECRCD", "AECRCF", "SYS_NC00024$" }),
        new JdeIndex("F48520_8", "Index on AEDOCO, AEDCTO, AEKCOO, AELNID, AEMCU, AEOBJ, AESUB, AEAN8, AECCOD, AECRCD, AECRCF, SYS_NC00024$", new[] { "AEDOCO", "AEDCTO", "AEKCOO", "AELNID", "AEMCU", "AEOBJ", "AESUB", "AEAN8", "AECCOD", "AECRCD", "AECRCF", "SYS_NC00024$" }),
        new JdeIndex("F48520_9", "Index on AEMCU, AESUB, AEOBJ, AEAN8, AEDOCO, AEDCTO, AEKCOO, AECOCH, AELNID, AECCOD, AECRCD, AECRCF, SYS_NC00024$", new[] { "AEMCU", "AESUB", "AEOBJ", "AEAN8", "AEDOCO", "AEDCTO", "AEKCOO", "AECOCH", "AELNID", "AECCOD", "AECRCD", "AECRCF", "SYS_NC00024$" })
    };
}
