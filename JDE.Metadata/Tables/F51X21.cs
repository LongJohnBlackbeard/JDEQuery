using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51X21 - .
/// </summary>
public class F51X21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BAUSER.
        /// </summary>
        public const string BAUSER = "BAUSER";

        /// <summary>
        /// BAJOBS.
        /// </summary>
        public const string BAJOBS = "BAJOBS";

        /// <summary>
        /// BAAID.
        /// </summary>
        public const string BAAID = "BAAID";

        /// <summary>
        /// BA51XBLG.
        /// </summary>
        public const string BA51XBLG = "BA51XBLG";

        /// <summary>
        /// BAMCU.
        /// </summary>
        public const string BAMCU = "BAMCU";

        /// <summary>
        /// BAOBJ.
        /// </summary>
        public const string BAOBJ = "BAOBJ";

        /// <summary>
        /// BASUB.
        /// </summary>
        public const string BASUB = "BASUB";

        /// <summary>
        /// BA51XB01.
        /// </summary>
        public const string BA51XB01 = "BA51XB01";

        /// <summary>
        /// BA51XB02.
        /// </summary>
        public const string BA51XB02 = "BA51XB02";

        /// <summary>
        /// BA51XB03.
        /// </summary>
        public const string BA51XB03 = "BA51XB03";

        /// <summary>
        /// BA51XB04.
        /// </summary>
        public const string BA51XB04 = "BA51XB04";

        /// <summary>
        /// BA51XB05.
        /// </summary>
        public const string BA51XB05 = "BA51XB05";

        /// <summary>
        /// BA51XB06.
        /// </summary>
        public const string BA51XB06 = "BA51XB06";

        /// <summary>
        /// BA51XB07.
        /// </summary>
        public const string BA51XB07 = "BA51XB07";

        /// <summary>
        /// BA51XB08.
        /// </summary>
        public const string BA51XB08 = "BA51XB08";

        /// <summary>
        /// BA51XB09.
        /// </summary>
        public const string BA51XB09 = "BA51XB09";

        /// <summary>
        /// BA51XB10.
        /// </summary>
        public const string BA51XB10 = "BA51XB10";

        /// <summary>
        /// BA51XB11.
        /// </summary>
        public const string BA51XB11 = "BA51XB11";

        /// <summary>
        /// BA51XB12.
        /// </summary>
        public const string BA51XB12 = "BA51XB12";

        /// <summary>
        /// BA51XB13.
        /// </summary>
        public const string BA51XB13 = "BA51XB13";

        /// <summary>
        /// BA51XB14.
        /// </summary>
        public const string BA51XB14 = "BA51XB14";

        /// <summary>
        /// BA51XB15.
        /// </summary>
        public const string BA51XB15 = "BA51XB15";

        /// <summary>
        /// BA51XB16.
        /// </summary>
        public const string BA51XB16 = "BA51XB16";

        /// <summary>
        /// BA51XB17.
        /// </summary>
        public const string BA51XB17 = "BA51XB17";

        /// <summary>
        /// BA51XB18.
        /// </summary>
        public const string BA51XB18 = "BA51XB18";

        /// <summary>
        /// BA51XB19.
        /// </summary>
        public const string BA51XB19 = "BA51XB19";

        /// <summary>
        /// BACRCD.
        /// </summary>
        public const string BACRCD = "BACRCD";

        /// <summary>
        /// BA51XBGA.
        /// </summary>
        public const string BA51XBGA = "BA51XBGA";
    }

    /// <inheritdoc />
    public override string TableName => "F51X21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BAUSER", "BAUSER", JdeDataType.String, 20, true, true),
        new JdeField("BAJOBS", "BAJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("BAAID", "BAAID", JdeDataType.String, 16, true, true),
        new JdeField("BA51XBLG", "BA51XBLG", JdeDataType.String, 2, true, true),
        new JdeField("BAMCU", "BAMCU", JdeDataType.String, 24, true, true),
        new JdeField("BAOBJ", "BAOBJ", JdeDataType.String, 12),
        new JdeField("BASUB", "BASUB", JdeDataType.String, 16),
        new JdeField("BA51XB01", "BA51XB01", JdeDataType.Numeric),
        new JdeField("BA51XB02", "BA51XB02", JdeDataType.Numeric),
        new JdeField("BA51XB03", "BA51XB03", JdeDataType.Numeric),
        new JdeField("BA51XB04", "BA51XB04", JdeDataType.Numeric),
        new JdeField("BA51XB05", "BA51XB05", JdeDataType.Numeric),
        new JdeField("BA51XB06", "BA51XB06", JdeDataType.Numeric),
        new JdeField("BA51XB07", "BA51XB07", JdeDataType.Numeric),
        new JdeField("BA51XB08", "BA51XB08", JdeDataType.Numeric),
        new JdeField("BA51XB09", "BA51XB09", JdeDataType.Numeric),
        new JdeField("BA51XB10", "BA51XB10", JdeDataType.Numeric),
        new JdeField("BA51XB11", "BA51XB11", JdeDataType.Numeric),
        new JdeField("BA51XB12", "BA51XB12", JdeDataType.Numeric),
        new JdeField("BA51XB13", "BA51XB13", JdeDataType.Numeric),
        new JdeField("BA51XB14", "BA51XB14", JdeDataType.Numeric),
        new JdeField("BA51XB15", "BA51XB15", JdeDataType.Numeric),
        new JdeField("BA51XB16", "BA51XB16", JdeDataType.Numeric),
        new JdeField("BA51XB17", "BA51XB17", JdeDataType.Numeric),
        new JdeField("BA51XB18", "BA51XB18", JdeDataType.Numeric),
        new JdeField("BA51XB19", "BA51XB19", JdeDataType.Numeric),
        new JdeField("BACRCD", "BACRCD", JdeDataType.String, 6),
        new JdeField("BA51XBGA", "BA51XBGA", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51X21_0", "Primary Key on BAUSER, BAJOBS, BAMCU, BAAID, BA51XBLG, BA51XBGA", new[] { "BAUSER", "BAJOBS", "BAMCU", "BAAID", "BA51XBLG", "BA51XBGA" }, isUnique: true, isPrimaryKey: true)
    };
}
