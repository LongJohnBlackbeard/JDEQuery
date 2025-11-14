using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P414T - .
/// </summary>
public class F76P414T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P4PYID.
        /// </summary>
        public const string P4PYID = "P4PYID";

        /// <summary>
        /// P4RC5.
        /// </summary>
        public const string P4RC5 = "P4RC5";

        /// <summary>
        /// P4DCTM.
        /// </summary>
        public const string P4DCTM = "P4DCTM";

        /// <summary>
        /// P4KCO.
        /// </summary>
        public const string P4KCO = "P4KCO";

        /// <summary>
        /// P4DCT.
        /// </summary>
        public const string P4DCT = "P4DCT";

        /// <summary>
        /// P4DOC.
        /// </summary>
        public const string P4DOC = "P4DOC";

        /// <summary>
        /// P4SFX.
        /// </summary>
        public const string P4SFX = "P4SFX";

        /// <summary>
        /// P4SFXE.
        /// </summary>
        public const string P4SFXE = "P4SFXE";

        /// <summary>
        /// P4P76CC01.
        /// </summary>
        public const string P4P76CC01 = "P4P76CC01";

        /// <summary>
        /// P4P76CC02.
        /// </summary>
        public const string P4P76CC02 = "P4P76CC02";

        /// <summary>
        /// P4P76CC03.
        /// </summary>
        public const string P4P76CC03 = "P4P76CC03";

        /// <summary>
        /// P4P76CC04.
        /// </summary>
        public const string P4P76CC04 = "P4P76CC04";

        /// <summary>
        /// P4P76CC05.
        /// </summary>
        public const string P4P76CC05 = "P4P76CC05";

        /// <summary>
        /// P4P76CC06.
        /// </summary>
        public const string P4P76CC06 = "P4P76CC06";

        /// <summary>
        /// P4P76CC07.
        /// </summary>
        public const string P4P76CC07 = "P4P76CC07";

        /// <summary>
        /// P4P76CC08.
        /// </summary>
        public const string P4P76CC08 = "P4P76CC08";

        /// <summary>
        /// P4P76CC09.
        /// </summary>
        public const string P4P76CC09 = "P4P76CC09";

        /// <summary>
        /// P4P76CC10.
        /// </summary>
        public const string P4P76CC10 = "P4P76CC10";

        /// <summary>
        /// P4P76PON.
        /// </summary>
        public const string P4P76PON = "P4P76PON";

        /// <summary>
        /// P4P76PIGV.
        /// </summary>
        public const string P4P76PIGV = "P4P76PIGV";

        /// <summary>
        /// P4H76FUA.
        /// </summary>
        public const string P4H76FUA = "P4H76FUA";

        /// <summary>
        /// P4H76FUC.
        /// </summary>
        public const string P4H76FUC = "P4H76FUC";

        /// <summary>
        /// P4H76FUD.
        /// </summary>
        public const string P4H76FUD = "P4H76FUD";

        /// <summary>
        /// P4H76FUR.
        /// </summary>
        public const string P4H76FUR = "P4H76FUR";

        /// <summary>
        /// P4H76FUF.
        /// </summary>
        public const string P4H76FUF = "P4H76FUF";

        /// <summary>
        /// P4USER.
        /// </summary>
        public const string P4USER = "P4USER";

        /// <summary>
        /// P4PID.
        /// </summary>
        public const string P4PID = "P4PID";

        /// <summary>
        /// P4UPMJ.
        /// </summary>
        public const string P4UPMJ = "P4UPMJ";

        /// <summary>
        /// P4UPMT.
        /// </summary>
        public const string P4UPMT = "P4UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76P414T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P4PYID", "P4PYID", JdeDataType.Numeric, null, true, true),
        new JdeField("P4RC5", "P4RC5", JdeDataType.Numeric, null, true, true),
        new JdeField("P4DCTM", "P4DCTM", JdeDataType.String, 4),
        new JdeField("P4KCO", "P4KCO", JdeDataType.String, 10),
        new JdeField("P4DCT", "P4DCT", JdeDataType.String, 4),
        new JdeField("P4DOC", "P4DOC", JdeDataType.Numeric),
        new JdeField("P4SFX", "P4SFX", JdeDataType.String, 6),
        new JdeField("P4SFXE", "P4SFXE", JdeDataType.Numeric),
        new JdeField("P4P76CC01", "P4P76CC01", JdeDataType.String, 6),
        new JdeField("P4P76CC02", "P4P76CC02", JdeDataType.String, 6),
        new JdeField("P4P76CC03", "P4P76CC03", JdeDataType.String, 6),
        new JdeField("P4P76CC04", "P4P76CC04", JdeDataType.String, 6),
        new JdeField("P4P76CC05", "P4P76CC05", JdeDataType.String, 6),
        new JdeField("P4P76CC06", "P4P76CC06", JdeDataType.String, 6),
        new JdeField("P4P76CC07", "P4P76CC07", JdeDataType.String, 6),
        new JdeField("P4P76CC08", "P4P76CC08", JdeDataType.String, 6),
        new JdeField("P4P76CC09", "P4P76CC09", JdeDataType.String, 6),
        new JdeField("P4P76CC10", "P4P76CC10", JdeDataType.String, 6),
        new JdeField("P4P76PON", "P4P76PON", JdeDataType.Numeric),
        new JdeField("P4P76PIGV", "P4P76PIGV", JdeDataType.String, 2),
        new JdeField("P4H76FUA", "P4H76FUA", JdeDataType.Numeric),
        new JdeField("P4H76FUC", "P4H76FUC", JdeDataType.String, 20),
        new JdeField("P4H76FUD", "P4H76FUD", JdeDataType.Numeric),
        new JdeField("P4H76FUR", "P4H76FUR", JdeDataType.String, 30),
        new JdeField("P4H76FUF", "P4H76FUF", JdeDataType.String, 2),
        new JdeField("P4USER", "P4USER", JdeDataType.String, 20),
        new JdeField("P4PID", "P4PID", JdeDataType.String, 20),
        new JdeField("P4UPMJ", "P4UPMJ", JdeDataType.Numeric),
        new JdeField("P4UPMT", "P4UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P414T_0", "Primary Key on P4PYID, P4RC5", new[] { "P4PYID", "P4RC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76P414T_3", "Index on P4DOC, P4DCT, P4KCO, P4SFX, P4SFXE", new[] { "P4DOC", "P4DCT", "P4KCO", "P4SFX", "P4SFXE" })
    };
}
