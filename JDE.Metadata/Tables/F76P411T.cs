using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P411T - .
/// </summary>
public class F76P411T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T4KCO.
        /// </summary>
        public const string T4KCO = "T4KCO";

        /// <summary>
        /// T4DCT.
        /// </summary>
        public const string T4DCT = "T4DCT";

        /// <summary>
        /// T4DOC.
        /// </summary>
        public const string T4DOC = "T4DOC";

        /// <summary>
        /// T4SFX.
        /// </summary>
        public const string T4SFX = "T4SFX";

        /// <summary>
        /// T4SFXE.
        /// </summary>
        public const string T4SFXE = "T4SFXE";

        /// <summary>
        /// T4H76LEDT.
        /// </summary>
        public const string T4H76LEDT = "T4H76LEDT";

        /// <summary>
        /// T4H76EMS.
        /// </summary>
        public const string T4H76EMS = "T4H76EMS";

        /// <summary>
        /// T4P76CC01.
        /// </summary>
        public const string T4P76CC01 = "T4P76CC01";

        /// <summary>
        /// T4P76CC02.
        /// </summary>
        public const string T4P76CC02 = "T4P76CC02";

        /// <summary>
        /// T4P76CC03.
        /// </summary>
        public const string T4P76CC03 = "T4P76CC03";

        /// <summary>
        /// T4P76CC04.
        /// </summary>
        public const string T4P76CC04 = "T4P76CC04";

        /// <summary>
        /// T4P76CC05.
        /// </summary>
        public const string T4P76CC05 = "T4P76CC05";

        /// <summary>
        /// T4P76CC06.
        /// </summary>
        public const string T4P76CC06 = "T4P76CC06";

        /// <summary>
        /// T4P76CC07.
        /// </summary>
        public const string T4P76CC07 = "T4P76CC07";

        /// <summary>
        /// T4P76CC08.
        /// </summary>
        public const string T4P76CC08 = "T4P76CC08";

        /// <summary>
        /// T4P76CC09.
        /// </summary>
        public const string T4P76CC09 = "T4P76CC09";

        /// <summary>
        /// T4P76CC10.
        /// </summary>
        public const string T4P76CC10 = "T4P76CC10";

        /// <summary>
        /// T4H76CC01.
        /// </summary>
        public const string T4H76CC01 = "T4H76CC01";

        /// <summary>
        /// T4H76CC02.
        /// </summary>
        public const string T4H76CC02 = "T4H76CC02";

        /// <summary>
        /// T4H76CC03.
        /// </summary>
        public const string T4H76CC03 = "T4H76CC03";

        /// <summary>
        /// T4ODOC.
        /// </summary>
        public const string T4ODOC = "T4ODOC";

        /// <summary>
        /// T4ODCT.
        /// </summary>
        public const string T4ODCT = "T4ODCT";

        /// <summary>
        /// T4OKCO.
        /// </summary>
        public const string T4OKCO = "T4OKCO";

        /// <summary>
        /// T4H76VPR.
        /// </summary>
        public const string T4H76VPR = "T4H76VPR";

        /// <summary>
        /// T4H76WH.
        /// </summary>
        public const string T4H76WH = "T4H76WH";

        /// <summary>
        /// T4H76WNBR.
        /// </summary>
        public const string T4H76WNBR = "T4H76WNBR";

        /// <summary>
        /// T4P76IGWC.
        /// </summary>
        public const string T4P76IGWC = "T4P76IGWC";

        /// <summary>
        /// T4P76IGWL.
        /// </summary>
        public const string T4P76IGWL = "T4P76IGWL";

        /// <summary>
        /// T4P76PIGV.
        /// </summary>
        public const string T4P76PIGV = "T4P76PIGV";

        /// <summary>
        /// T4P76PVPR.
        /// </summary>
        public const string T4P76PVPR = "T4P76PVPR";

        /// <summary>
        /// T4P76PWH.
        /// </summary>
        public const string T4P76PWH = "T4P76PWH";

        /// <summary>
        /// T4P76DVPR.
        /// </summary>
        public const string T4P76DVPR = "T4P76DVPR";

        /// <summary>
        /// T4USER.
        /// </summary>
        public const string T4USER = "T4USER";

        /// <summary>
        /// T4PID.
        /// </summary>
        public const string T4PID = "T4PID";

        /// <summary>
        /// T4JOBN.
        /// </summary>
        public const string T4JOBN = "T4JOBN";

        /// <summary>
        /// T4UPMJ.
        /// </summary>
        public const string T4UPMJ = "T4UPMJ";

        /// <summary>
        /// T4UPMT.
        /// </summary>
        public const string T4UPMT = "T4UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76P411T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T4KCO", "T4KCO", JdeDataType.String, 10, true, true),
        new JdeField("T4DCT", "T4DCT", JdeDataType.String, 4, true, true),
        new JdeField("T4DOC", "T4DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("T4SFX", "T4SFX", JdeDataType.String, 6, true, true),
        new JdeField("T4SFXE", "T4SFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("T4H76LEDT", "T4H76LEDT", JdeDataType.String, 6),
        new JdeField("T4H76EMS", "T4H76EMS", JdeDataType.String, 8),
        new JdeField("T4P76CC01", "T4P76CC01", JdeDataType.String, 6),
        new JdeField("T4P76CC02", "T4P76CC02", JdeDataType.String, 6),
        new JdeField("T4P76CC03", "T4P76CC03", JdeDataType.String, 6),
        new JdeField("T4P76CC04", "T4P76CC04", JdeDataType.String, 6),
        new JdeField("T4P76CC05", "T4P76CC05", JdeDataType.String, 6),
        new JdeField("T4P76CC06", "T4P76CC06", JdeDataType.String, 6),
        new JdeField("T4P76CC07", "T4P76CC07", JdeDataType.String, 6),
        new JdeField("T4P76CC08", "T4P76CC08", JdeDataType.String, 6),
        new JdeField("T4P76CC09", "T4P76CC09", JdeDataType.String, 6),
        new JdeField("T4P76CC10", "T4P76CC10", JdeDataType.String, 6),
        new JdeField("T4H76CC01", "T4H76CC01", JdeDataType.String, 6),
        new JdeField("T4H76CC02", "T4H76CC02", JdeDataType.String, 6),
        new JdeField("T4H76CC03", "T4H76CC03", JdeDataType.String, 6),
        new JdeField("T4ODOC", "T4ODOC", JdeDataType.Numeric),
        new JdeField("T4ODCT", "T4ODCT", JdeDataType.String, 4),
        new JdeField("T4OKCO", "T4OKCO", JdeDataType.String, 10),
        new JdeField("T4H76VPR", "T4H76VPR", JdeDataType.String, 2),
        new JdeField("T4H76WH", "T4H76WH", JdeDataType.String, 2),
        new JdeField("T4H76WNBR", "T4H76WNBR", JdeDataType.Numeric),
        new JdeField("T4P76IGWC", "T4P76IGWC", JdeDataType.Numeric),
        new JdeField("T4P76IGWL", "T4P76IGWL", JdeDataType.String, 2),
        new JdeField("T4P76PIGV", "T4P76PIGV", JdeDataType.String, 2),
        new JdeField("T4P76PVPR", "T4P76PVPR", JdeDataType.String, 2),
        new JdeField("T4P76PWH", "T4P76PWH", JdeDataType.String, 2),
        new JdeField("T4P76DVPR", "T4P76DVPR", JdeDataType.String, 2),
        new JdeField("T4USER", "T4USER", JdeDataType.String, 20),
        new JdeField("T4PID", "T4PID", JdeDataType.String, 20),
        new JdeField("T4JOBN", "T4JOBN", JdeDataType.String, 20),
        new JdeField("T4UPMJ", "T4UPMJ", JdeDataType.Numeric),
        new JdeField("T4UPMT", "T4UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P411T_0", "Primary Key on T4KCO, T4DCT, T4DOC, T4SFX, T4SFXE", new[] { "T4KCO", "T4DCT", "T4DOC", "T4SFX", "T4SFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
