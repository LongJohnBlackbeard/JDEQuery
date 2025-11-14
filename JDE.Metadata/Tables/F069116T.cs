using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069116T - .
/// </summary>
public class F069116T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YCPDBA.
        /// </summary>
        public const string YCPDBA = "YCPDBA";

        /// <summary>
        /// YCTT16.
        /// </summary>
        public const string YCTT16 = "YCTT16";

        /// <summary>
        /// YCTT17.
        /// </summary>
        public const string YCTT17 = "YCTT17";

        /// <summary>
        /// YCTT18.
        /// </summary>
        public const string YCTT18 = "YCTT18";

        /// <summary>
        /// YCTT19.
        /// </summary>
        public const string YCTT19 = "YCTT19";

        /// <summary>
        /// YCTT20.
        /// </summary>
        public const string YCTT20 = "YCTT20";

        /// <summary>
        /// YCTT21.
        /// </summary>
        public const string YCTT21 = "YCTT21";

        /// <summary>
        /// YCTT22.
        /// </summary>
        public const string YCTT22 = "YCTT22";

        /// <summary>
        /// YCTT23.
        /// </summary>
        public const string YCTT23 = "YCTT23";

        /// <summary>
        /// YCTT24.
        /// </summary>
        public const string YCTT24 = "YCTT24";

        /// <summary>
        /// YCTT25.
        /// </summary>
        public const string YCTT25 = "YCTT25";

        /// <summary>
        /// YCTT26.
        /// </summary>
        public const string YCTT26 = "YCTT26";

        /// <summary>
        /// YCTT27.
        /// </summary>
        public const string YCTT27 = "YCTT27";

        /// <summary>
        /// YCTT28.
        /// </summary>
        public const string YCTT28 = "YCTT28";

        /// <summary>
        /// YCTT29.
        /// </summary>
        public const string YCTT29 = "YCTT29";

        /// <summary>
        /// YCTT30.
        /// </summary>
        public const string YCTT30 = "YCTT30";

        /// <summary>
        /// YCTT31.
        /// </summary>
        public const string YCTT31 = "YCTT31";

        /// <summary>
        /// YCTT32.
        /// </summary>
        public const string YCTT32 = "YCTT32";

        /// <summary>
        /// YCTT33.
        /// </summary>
        public const string YCTT33 = "YCTT33";

        /// <summary>
        /// YCTT34.
        /// </summary>
        public const string YCTT34 = "YCTT34";

        /// <summary>
        /// YCTT35.
        /// </summary>
        public const string YCTT35 = "YCTT35";

        /// <summary>
        /// YCTT36.
        /// </summary>
        public const string YCTT36 = "YCTT36";

        /// <summary>
        /// YCPDBADT01.
        /// </summary>
        public const string YCPDBADT01 = "YCPDBADT01";

        /// <summary>
        /// YCPDBADT02.
        /// </summary>
        public const string YCPDBADT02 = "YCPDBADT02";

        /// <summary>
        /// YCPDBADT03.
        /// </summary>
        public const string YCPDBADT03 = "YCPDBADT03";

        /// <summary>
        /// YCPDBADT04.
        /// </summary>
        public const string YCPDBADT04 = "YCPDBADT04";

        /// <summary>
        /// YCPDBADT05.
        /// </summary>
        public const string YCPDBADT05 = "YCPDBADT05";

        /// <summary>
        /// YCPDBAMN01.
        /// </summary>
        public const string YCPDBAMN01 = "YCPDBAMN01";

        /// <summary>
        /// YCPDBAMN02.
        /// </summary>
        public const string YCPDBAMN02 = "YCPDBAMN02";

        /// <summary>
        /// YCPDBAMN03.
        /// </summary>
        public const string YCPDBAMN03 = "YCPDBAMN03";

        /// <summary>
        /// YCPDBAMN04.
        /// </summary>
        public const string YCPDBAMN04 = "YCPDBAMN04";

        /// <summary>
        /// YCPDBAMN05.
        /// </summary>
        public const string YCPDBAMN05 = "YCPDBAMN05";

        /// <summary>
        /// YCPDBACH01.
        /// </summary>
        public const string YCPDBACH01 = "YCPDBACH01";

        /// <summary>
        /// YCPDBACH02.
        /// </summary>
        public const string YCPDBACH02 = "YCPDBACH02";

        /// <summary>
        /// YCPDBACH03.
        /// </summary>
        public const string YCPDBACH03 = "YCPDBACH03";

        /// <summary>
        /// YCPDBACH04.
        /// </summary>
        public const string YCPDBACH04 = "YCPDBACH04";

        /// <summary>
        /// YCPDBACH05.
        /// </summary>
        public const string YCPDBACH05 = "YCPDBACH05";

        /// <summary>
        /// YCPDBAST01.
        /// </summary>
        public const string YCPDBAST01 = "YCPDBAST01";

        /// <summary>
        /// YCPDBAST02.
        /// </summary>
        public const string YCPDBAST02 = "YCPDBAST02";

        /// <summary>
        /// YCPDBAST03.
        /// </summary>
        public const string YCPDBAST03 = "YCPDBAST03";

        /// <summary>
        /// YCPDBAST04.
        /// </summary>
        public const string YCPDBAST04 = "YCPDBAST04";

        /// <summary>
        /// YCPDBAST05.
        /// </summary>
        public const string YCPDBAST05 = "YCPDBAST05";

        /// <summary>
        /// YCUSER.
        /// </summary>
        public const string YCUSER = "YCUSER";

        /// <summary>
        /// YCPID.
        /// </summary>
        public const string YCPID = "YCPID";

        /// <summary>
        /// YCUPMJ.
        /// </summary>
        public const string YCUPMJ = "YCUPMJ";

        /// <summary>
        /// YCJOBN.
        /// </summary>
        public const string YCJOBN = "YCJOBN";

        /// <summary>
        /// YCUPMT.
        /// </summary>
        public const string YCUPMT = "YCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F069116T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YCPDBA", "YCPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YCTT16", "YCTT16", JdeDataType.String, 4),
        new JdeField("YCTT17", "YCTT17", JdeDataType.String, 4),
        new JdeField("YCTT18", "YCTT18", JdeDataType.String, 4),
        new JdeField("YCTT19", "YCTT19", JdeDataType.String, 4),
        new JdeField("YCTT20", "YCTT20", JdeDataType.String, 4),
        new JdeField("YCTT21", "YCTT21", JdeDataType.String, 4),
        new JdeField("YCTT22", "YCTT22", JdeDataType.String, 4),
        new JdeField("YCTT23", "YCTT23", JdeDataType.String, 4),
        new JdeField("YCTT24", "YCTT24", JdeDataType.String, 4),
        new JdeField("YCTT25", "YCTT25", JdeDataType.String, 4),
        new JdeField("YCTT26", "YCTT26", JdeDataType.String, 4),
        new JdeField("YCTT27", "YCTT27", JdeDataType.String, 4),
        new JdeField("YCTT28", "YCTT28", JdeDataType.String, 4),
        new JdeField("YCTT29", "YCTT29", JdeDataType.String, 4),
        new JdeField("YCTT30", "YCTT30", JdeDataType.String, 4),
        new JdeField("YCTT31", "YCTT31", JdeDataType.String, 4),
        new JdeField("YCTT32", "YCTT32", JdeDataType.String, 4),
        new JdeField("YCTT33", "YCTT33", JdeDataType.String, 4),
        new JdeField("YCTT34", "YCTT34", JdeDataType.String, 4),
        new JdeField("YCTT35", "YCTT35", JdeDataType.String, 4),
        new JdeField("YCTT36", "YCTT36", JdeDataType.String, 4),
        new JdeField("YCPDBADT01", "YCPDBADT01", JdeDataType.Numeric),
        new JdeField("YCPDBADT02", "YCPDBADT02", JdeDataType.Numeric),
        new JdeField("YCPDBADT03", "YCPDBADT03", JdeDataType.Numeric),
        new JdeField("YCPDBADT04", "YCPDBADT04", JdeDataType.Numeric),
        new JdeField("YCPDBADT05", "YCPDBADT05", JdeDataType.Numeric),
        new JdeField("YCPDBAMN01", "YCPDBAMN01", JdeDataType.Numeric),
        new JdeField("YCPDBAMN02", "YCPDBAMN02", JdeDataType.Numeric),
        new JdeField("YCPDBAMN03", "YCPDBAMN03", JdeDataType.Numeric),
        new JdeField("YCPDBAMN04", "YCPDBAMN04", JdeDataType.Numeric),
        new JdeField("YCPDBAMN05", "YCPDBAMN05", JdeDataType.Numeric),
        new JdeField("YCPDBACH01", "YCPDBACH01", JdeDataType.String, 2),
        new JdeField("YCPDBACH02", "YCPDBACH02", JdeDataType.String, 2),
        new JdeField("YCPDBACH03", "YCPDBACH03", JdeDataType.String, 2),
        new JdeField("YCPDBACH04", "YCPDBACH04", JdeDataType.String, 2),
        new JdeField("YCPDBACH05", "YCPDBACH05", JdeDataType.String, 2),
        new JdeField("YCPDBAST01", "YCPDBAST01", JdeDataType.String, 60),
        new JdeField("YCPDBAST02", "YCPDBAST02", JdeDataType.String, 60),
        new JdeField("YCPDBAST03", "YCPDBAST03", JdeDataType.String, 60),
        new JdeField("YCPDBAST04", "YCPDBAST04", JdeDataType.String, 60),
        new JdeField("YCPDBAST05", "YCPDBAST05", JdeDataType.String, 60),
        new JdeField("YCUSER", "YCUSER", JdeDataType.String, 20),
        new JdeField("YCPID", "YCPID", JdeDataType.String, 20),
        new JdeField("YCUPMJ", "YCUPMJ", JdeDataType.Numeric),
        new JdeField("YCJOBN", "YCJOBN", JdeDataType.String, 20),
        new JdeField("YCUPMT", "YCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069116T_0", "Primary Key on YCPDBA", new[] { "YCPDBA" }, isUnique: true, isPrimaryKey: true)
    };
}
