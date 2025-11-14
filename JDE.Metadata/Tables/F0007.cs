using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0007 - .
/// </summary>
public class F0007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CZCTRY.
        /// </summary>
        public const string CZCTRY = "CZCTRY";

        /// <summary>
        /// CZMMCU.
        /// </summary>
        public const string CZMMCU = "CZMMCU";

        /// <summary>
        /// CZYR.
        /// </summary>
        public const string CZYR = "CZYR";

        /// <summary>
        /// CZMT.
        /// </summary>
        public const string CZMT = "CZMT";

        /// <summary>
        /// CZSHFT.
        /// </summary>
        public const string CZSHFT = "CZSHFT";

        /// <summary>
        /// CZTD01.
        /// </summary>
        public const string CZTD01 = "CZTD01";

        /// <summary>
        /// CZTD02.
        /// </summary>
        public const string CZTD02 = "CZTD02";

        /// <summary>
        /// CZTD03.
        /// </summary>
        public const string CZTD03 = "CZTD03";

        /// <summary>
        /// CZTD04.
        /// </summary>
        public const string CZTD04 = "CZTD04";

        /// <summary>
        /// CZTD05.
        /// </summary>
        public const string CZTD05 = "CZTD05";

        /// <summary>
        /// CZTD06.
        /// </summary>
        public const string CZTD06 = "CZTD06";

        /// <summary>
        /// CZTD07.
        /// </summary>
        public const string CZTD07 = "CZTD07";

        /// <summary>
        /// CZTD08.
        /// </summary>
        public const string CZTD08 = "CZTD08";

        /// <summary>
        /// CZTD09.
        /// </summary>
        public const string CZTD09 = "CZTD09";

        /// <summary>
        /// CZTD10.
        /// </summary>
        public const string CZTD10 = "CZTD10";

        /// <summary>
        /// CZTD11.
        /// </summary>
        public const string CZTD11 = "CZTD11";

        /// <summary>
        /// CZTD12.
        /// </summary>
        public const string CZTD12 = "CZTD12";

        /// <summary>
        /// CZTD13.
        /// </summary>
        public const string CZTD13 = "CZTD13";

        /// <summary>
        /// CZTD14.
        /// </summary>
        public const string CZTD14 = "CZTD14";

        /// <summary>
        /// CZTD15.
        /// </summary>
        public const string CZTD15 = "CZTD15";

        /// <summary>
        /// CZTD16.
        /// </summary>
        public const string CZTD16 = "CZTD16";

        /// <summary>
        /// CZTD17.
        /// </summary>
        public const string CZTD17 = "CZTD17";

        /// <summary>
        /// CZTD18.
        /// </summary>
        public const string CZTD18 = "CZTD18";

        /// <summary>
        /// CZTD19.
        /// </summary>
        public const string CZTD19 = "CZTD19";

        /// <summary>
        /// CZTD20.
        /// </summary>
        public const string CZTD20 = "CZTD20";

        /// <summary>
        /// CZTD21.
        /// </summary>
        public const string CZTD21 = "CZTD21";

        /// <summary>
        /// CZTD22.
        /// </summary>
        public const string CZTD22 = "CZTD22";

        /// <summary>
        /// CZTD23.
        /// </summary>
        public const string CZTD23 = "CZTD23";

        /// <summary>
        /// CZTD24.
        /// </summary>
        public const string CZTD24 = "CZTD24";

        /// <summary>
        /// CZTD25.
        /// </summary>
        public const string CZTD25 = "CZTD25";

        /// <summary>
        /// CZTD26.
        /// </summary>
        public const string CZTD26 = "CZTD26";

        /// <summary>
        /// CZTD27.
        /// </summary>
        public const string CZTD27 = "CZTD27";

        /// <summary>
        /// CZTD28.
        /// </summary>
        public const string CZTD28 = "CZTD28";

        /// <summary>
        /// CZTD29.
        /// </summary>
        public const string CZTD29 = "CZTD29";

        /// <summary>
        /// CZTD30.
        /// </summary>
        public const string CZTD30 = "CZTD30";

        /// <summary>
        /// CZTD31.
        /// </summary>
        public const string CZTD31 = "CZTD31";

        /// <summary>
        /// CZJOBN.
        /// </summary>
        public const string CZJOBN = "CZJOBN";

        /// <summary>
        /// CZPID.
        /// </summary>
        public const string CZPID = "CZPID";

        /// <summary>
        /// CZUSER.
        /// </summary>
        public const string CZUSER = "CZUSER";

        /// <summary>
        /// CZUPMJ.
        /// </summary>
        public const string CZUPMJ = "CZUPMJ";

        /// <summary>
        /// CZTDAY.
        /// </summary>
        public const string CZTDAY = "CZTDAY";

        /// <summary>
        /// CZWDCT.
        /// </summary>
        public const string CZWDCT = "CZWDCT";

        /// <summary>
        /// CZWDCK.
        /// </summary>
        public const string CZWDCK = "CZWDCK";
    }

    /// <inheritdoc />
    public override string TableName => "F0007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CZCTRY", "CZCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("CZMMCU", "CZMMCU", JdeDataType.String, 24, true, true),
        new JdeField("CZYR", "CZYR", JdeDataType.Numeric, null, true, true),
        new JdeField("CZMT", "CZMT", JdeDataType.Numeric, null, true, true),
        new JdeField("CZSHFT", "CZSHFT", JdeDataType.String, 2, true, true),
        new JdeField("CZTD01", "CZTD01", JdeDataType.String, 2),
        new JdeField("CZTD02", "CZTD02", JdeDataType.String, 2),
        new JdeField("CZTD03", "CZTD03", JdeDataType.String, 2),
        new JdeField("CZTD04", "CZTD04", JdeDataType.String, 2),
        new JdeField("CZTD05", "CZTD05", JdeDataType.String, 2),
        new JdeField("CZTD06", "CZTD06", JdeDataType.String, 2),
        new JdeField("CZTD07", "CZTD07", JdeDataType.String, 2),
        new JdeField("CZTD08", "CZTD08", JdeDataType.String, 2),
        new JdeField("CZTD09", "CZTD09", JdeDataType.String, 2),
        new JdeField("CZTD10", "CZTD10", JdeDataType.String, 2),
        new JdeField("CZTD11", "CZTD11", JdeDataType.String, 2),
        new JdeField("CZTD12", "CZTD12", JdeDataType.String, 2),
        new JdeField("CZTD13", "CZTD13", JdeDataType.String, 2),
        new JdeField("CZTD14", "CZTD14", JdeDataType.String, 2),
        new JdeField("CZTD15", "CZTD15", JdeDataType.String, 2),
        new JdeField("CZTD16", "CZTD16", JdeDataType.String, 2),
        new JdeField("CZTD17", "CZTD17", JdeDataType.String, 2),
        new JdeField("CZTD18", "CZTD18", JdeDataType.String, 2),
        new JdeField("CZTD19", "CZTD19", JdeDataType.String, 2),
        new JdeField("CZTD20", "CZTD20", JdeDataType.String, 2),
        new JdeField("CZTD21", "CZTD21", JdeDataType.String, 2),
        new JdeField("CZTD22", "CZTD22", JdeDataType.String, 2),
        new JdeField("CZTD23", "CZTD23", JdeDataType.String, 2),
        new JdeField("CZTD24", "CZTD24", JdeDataType.String, 2),
        new JdeField("CZTD25", "CZTD25", JdeDataType.String, 2),
        new JdeField("CZTD26", "CZTD26", JdeDataType.String, 2),
        new JdeField("CZTD27", "CZTD27", JdeDataType.String, 2),
        new JdeField("CZTD28", "CZTD28", JdeDataType.String, 2),
        new JdeField("CZTD29", "CZTD29", JdeDataType.String, 2),
        new JdeField("CZTD30", "CZTD30", JdeDataType.String, 2),
        new JdeField("CZTD31", "CZTD31", JdeDataType.String, 2),
        new JdeField("CZJOBN", "CZJOBN", JdeDataType.String, 20),
        new JdeField("CZPID", "CZPID", JdeDataType.String, 20),
        new JdeField("CZUSER", "CZUSER", JdeDataType.String, 20),
        new JdeField("CZUPMJ", "CZUPMJ", JdeDataType.Numeric),
        new JdeField("CZTDAY", "CZTDAY", JdeDataType.Numeric),
        new JdeField("CZWDCT", "CZWDCT", JdeDataType.String, 20, true, true),
        new JdeField("CZWDCK", "CZWDCK", JdeDataType.String, 20, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0007_0", "Primary Key on CZMMCU, CZWDCT, CZWDCK, CZCTRY, CZYR, CZMT, CZSHFT", new[] { "CZMMCU", "CZWDCT", "CZWDCK", "CZCTRY", "CZYR", "CZMT", "CZSHFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0007_1", "Unique Index on CZMMCU, CZWDCT, CZWDCK, CZYR, CZMT, CZSHFT", new[] { "CZMMCU", "CZWDCT", "CZWDCK", "CZYR", "CZMT", "CZSHFT" }, isUnique: true),
        new JdeIndex("F0007_3", "Index on CZMMCU, CZWDCK", new[] { "CZMMCU", "CZWDCK" })
    };
}
