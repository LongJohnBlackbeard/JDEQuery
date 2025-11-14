using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51X91 - .
/// </summary>
public class F51X91 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// X251XICL.
        /// </summary>
        public const string X251XICL = "X251XICL";

        /// <summary>
        /// X2DL01.
        /// </summary>
        public const string X2DL01 = "X2DL01";

        /// <summary>
        /// X251XCOL01.
        /// </summary>
        public const string X251XCOL01 = "X251XCOL01";

        /// <summary>
        /// X251XCOL02.
        /// </summary>
        public const string X251XCOL02 = "X251XCOL02";

        /// <summary>
        /// X251XCOL03.
        /// </summary>
        public const string X251XCOL03 = "X251XCOL03";

        /// <summary>
        /// X251XCOL04.
        /// </summary>
        public const string X251XCOL04 = "X251XCOL04";

        /// <summary>
        /// X251XCOL05.
        /// </summary>
        public const string X251XCOL05 = "X251XCOL05";

        /// <summary>
        /// X251XCOL06.
        /// </summary>
        public const string X251XCOL06 = "X251XCOL06";

        /// <summary>
        /// X251XCOL07.
        /// </summary>
        public const string X251XCOL07 = "X251XCOL07";

        /// <summary>
        /// X251XCOL08.
        /// </summary>
        public const string X251XCOL08 = "X251XCOL08";

        /// <summary>
        /// X251XCOL09.
        /// </summary>
        public const string X251XCOL09 = "X251XCOL09";

        /// <summary>
        /// X251XCOL10.
        /// </summary>
        public const string X251XCOL10 = "X251XCOL10";

        /// <summary>
        /// X251XCOL11.
        /// </summary>
        public const string X251XCOL11 = "X251XCOL11";

        /// <summary>
        /// X251XCOL12.
        /// </summary>
        public const string X251XCOL12 = "X251XCOL12";

        /// <summary>
        /// X251XCOL13.
        /// </summary>
        public const string X251XCOL13 = "X251XCOL13";

        /// <summary>
        /// X251XCOL14.
        /// </summary>
        public const string X251XCOL14 = "X251XCOL14";

        /// <summary>
        /// X251XCOL15.
        /// </summary>
        public const string X251XCOL15 = "X251XCOL15";

        /// <summary>
        /// X251XCOL16.
        /// </summary>
        public const string X251XCOL16 = "X251XCOL16";

        /// <summary>
        /// X251XCOL17.
        /// </summary>
        public const string X251XCOL17 = "X251XCOL17";

        /// <summary>
        /// X251XCOL18.
        /// </summary>
        public const string X251XCOL18 = "X251XCOL18";

        /// <summary>
        /// X251XCOL19.
        /// </summary>
        public const string X251XCOL19 = "X251XCOL19";

        /// <summary>
        /// X251XCOL20.
        /// </summary>
        public const string X251XCOL20 = "X251XCOL20";

        /// <summary>
        /// X251XCOL21.
        /// </summary>
        public const string X251XCOL21 = "X251XCOL21";

        /// <summary>
        /// X251XCOL22.
        /// </summary>
        public const string X251XCOL22 = "X251XCOL22";

        /// <summary>
        /// X251XCOL23.
        /// </summary>
        public const string X251XCOL23 = "X251XCOL23";

        /// <summary>
        /// X251XCOL24.
        /// </summary>
        public const string X251XCOL24 = "X251XCOL24";

        /// <summary>
        /// X251XCOL25.
        /// </summary>
        public const string X251XCOL25 = "X251XCOL25";

        /// <summary>
        /// X251XCOL26.
        /// </summary>
        public const string X251XCOL26 = "X251XCOL26";

        /// <summary>
        /// X251XCOL27.
        /// </summary>
        public const string X251XCOL27 = "X251XCOL27";

        /// <summary>
        /// X251XCOL28.
        /// </summary>
        public const string X251XCOL28 = "X251XCOL28";

        /// <summary>
        /// X251XCOL29.
        /// </summary>
        public const string X251XCOL29 = "X251XCOL29";

        /// <summary>
        /// X251XCOL30.
        /// </summary>
        public const string X251XCOL30 = "X251XCOL30";

        /// <summary>
        /// X251XCOL31.
        /// </summary>
        public const string X251XCOL31 = "X251XCOL31";

        /// <summary>
        /// X251XCOL32.
        /// </summary>
        public const string X251XCOL32 = "X251XCOL32";

        /// <summary>
        /// X251XCOL33.
        /// </summary>
        public const string X251XCOL33 = "X251XCOL33";

        /// <summary>
        /// X251XCOL34.
        /// </summary>
        public const string X251XCOL34 = "X251XCOL34";

        /// <summary>
        /// X251XCOL35.
        /// </summary>
        public const string X251XCOL35 = "X251XCOL35";

        /// <summary>
        /// X251XCOL36.
        /// </summary>
        public const string X251XCOL36 = "X251XCOL36";

        /// <summary>
        /// X251XCOL37.
        /// </summary>
        public const string X251XCOL37 = "X251XCOL37";

        /// <summary>
        /// X251XCOL38.
        /// </summary>
        public const string X251XCOL38 = "X251XCOL38";

        /// <summary>
        /// X251XCOL39.
        /// </summary>
        public const string X251XCOL39 = "X251XCOL39";

        /// <summary>
        /// X251XCOL40.
        /// </summary>
        public const string X251XCOL40 = "X251XCOL40";

        /// <summary>
        /// X251X01IC.
        /// </summary>
        public const string X251X01IC = "X251X01IC";

        /// <summary>
        /// X251X02IC.
        /// </summary>
        public const string X251X02IC = "X251X02IC";

        /// <summary>
        /// X251X03IC.
        /// </summary>
        public const string X251X03IC = "X251X03IC";

        /// <summary>
        /// X251X04IC.
        /// </summary>
        public const string X251X04IC = "X251X04IC";

        /// <summary>
        /// X251X05IC.
        /// </summary>
        public const string X251X05IC = "X251X05IC";

        /// <summary>
        /// X251X06IC.
        /// </summary>
        public const string X251X06IC = "X251X06IC";

        /// <summary>
        /// X251X07IC.
        /// </summary>
        public const string X251X07IC = "X251X07IC";

        /// <summary>
        /// X251X08IC.
        /// </summary>
        public const string X251X08IC = "X251X08IC";

        /// <summary>
        /// X251X09IC.
        /// </summary>
        public const string X251X09IC = "X251X09IC";

        /// <summary>
        /// X251X10IC.
        /// </summary>
        public const string X251X10IC = "X251X10IC";

        /// <summary>
        /// X251X11IC.
        /// </summary>
        public const string X251X11IC = "X251X11IC";

        /// <summary>
        /// X251X12IC.
        /// </summary>
        public const string X251X12IC = "X251X12IC";

        /// <summary>
        /// X251X13IC.
        /// </summary>
        public const string X251X13IC = "X251X13IC";

        /// <summary>
        /// X251X14IC.
        /// </summary>
        public const string X251X14IC = "X251X14IC";

        /// <summary>
        /// X251X15IC.
        /// </summary>
        public const string X251X15IC = "X251X15IC";

        /// <summary>
        /// X251X16IC.
        /// </summary>
        public const string X251X16IC = "X251X16IC";

        /// <summary>
        /// X251X17IC.
        /// </summary>
        public const string X251X17IC = "X251X17IC";

        /// <summary>
        /// X251X18IC.
        /// </summary>
        public const string X251X18IC = "X251X18IC";

        /// <summary>
        /// X251X19IC.
        /// </summary>
        public const string X251X19IC = "X251X19IC";

        /// <summary>
        /// X251X20IC.
        /// </summary>
        public const string X251X20IC = "X251X20IC";

        /// <summary>
        /// X251X21IC.
        /// </summary>
        public const string X251X21IC = "X251X21IC";

        /// <summary>
        /// X251X22IC.
        /// </summary>
        public const string X251X22IC = "X251X22IC";

        /// <summary>
        /// X251X23IC.
        /// </summary>
        public const string X251X23IC = "X251X23IC";

        /// <summary>
        /// X251X24IC.
        /// </summary>
        public const string X251X24IC = "X251X24IC";

        /// <summary>
        /// X251X25IC.
        /// </summary>
        public const string X251X25IC = "X251X25IC";

        /// <summary>
        /// X251X26IC.
        /// </summary>
        public const string X251X26IC = "X251X26IC";

        /// <summary>
        /// X251X27IC.
        /// </summary>
        public const string X251X27IC = "X251X27IC";

        /// <summary>
        /// X251X28IC.
        /// </summary>
        public const string X251X28IC = "X251X28IC";

        /// <summary>
        /// X251X29IC.
        /// </summary>
        public const string X251X29IC = "X251X29IC";

        /// <summary>
        /// X251X30IC.
        /// </summary>
        public const string X251X30IC = "X251X30IC";

        /// <summary>
        /// X251X31IC.
        /// </summary>
        public const string X251X31IC = "X251X31IC";

        /// <summary>
        /// X251X32IC.
        /// </summary>
        public const string X251X32IC = "X251X32IC";

        /// <summary>
        /// X251X33IC.
        /// </summary>
        public const string X251X33IC = "X251X33IC";

        /// <summary>
        /// X251X34IC.
        /// </summary>
        public const string X251X34IC = "X251X34IC";

        /// <summary>
        /// X251X35IC.
        /// </summary>
        public const string X251X35IC = "X251X35IC";

        /// <summary>
        /// X251X36IC.
        /// </summary>
        public const string X251X36IC = "X251X36IC";

        /// <summary>
        /// X251X37IC.
        /// </summary>
        public const string X251X37IC = "X251X37IC";

        /// <summary>
        /// X251X38IC.
        /// </summary>
        public const string X251X38IC = "X251X38IC";

        /// <summary>
        /// X251X39IC.
        /// </summary>
        public const string X251X39IC = "X251X39IC";

        /// <summary>
        /// X251X40IC.
        /// </summary>
        public const string X251X40IC = "X251X40IC";

        /// <summary>
        /// X2USER.
        /// </summary>
        public const string X2USER = "X2USER";

        /// <summary>
        /// X2PID.
        /// </summary>
        public const string X2PID = "X2PID";

        /// <summary>
        /// X2JOB.
        /// </summary>
        public const string X2JOB = "X2JOB";

        /// <summary>
        /// X2UPMJ.
        /// </summary>
        public const string X2UPMJ = "X2UPMJ";

        /// <summary>
        /// X2UPMT.
        /// </summary>
        public const string X2UPMT = "X2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F51X91";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("X251XICL", "X251XICL", JdeDataType.String, 20, true, true),
        new JdeField("X2DL01", "X2DL01", JdeDataType.String, 60),
        new JdeField("X251XCOL01", "X251XCOL01", JdeDataType.String, 12),
        new JdeField("X251XCOL02", "X251XCOL02", JdeDataType.String, 12),
        new JdeField("X251XCOL03", "X251XCOL03", JdeDataType.String, 12),
        new JdeField("X251XCOL04", "X251XCOL04", JdeDataType.String, 12),
        new JdeField("X251XCOL05", "X251XCOL05", JdeDataType.String, 12),
        new JdeField("X251XCOL06", "X251XCOL06", JdeDataType.String, 12),
        new JdeField("X251XCOL07", "X251XCOL07", JdeDataType.String, 12),
        new JdeField("X251XCOL08", "X251XCOL08", JdeDataType.String, 12),
        new JdeField("X251XCOL09", "X251XCOL09", JdeDataType.String, 12),
        new JdeField("X251XCOL10", "X251XCOL10", JdeDataType.String, 12),
        new JdeField("X251XCOL11", "X251XCOL11", JdeDataType.String, 12),
        new JdeField("X251XCOL12", "X251XCOL12", JdeDataType.String, 12),
        new JdeField("X251XCOL13", "X251XCOL13", JdeDataType.String, 12),
        new JdeField("X251XCOL14", "X251XCOL14", JdeDataType.String, 12),
        new JdeField("X251XCOL15", "X251XCOL15", JdeDataType.String, 12),
        new JdeField("X251XCOL16", "X251XCOL16", JdeDataType.String, 12),
        new JdeField("X251XCOL17", "X251XCOL17", JdeDataType.String, 12),
        new JdeField("X251XCOL18", "X251XCOL18", JdeDataType.String, 12),
        new JdeField("X251XCOL19", "X251XCOL19", JdeDataType.String, 12),
        new JdeField("X251XCOL20", "X251XCOL20", JdeDataType.String, 12),
        new JdeField("X251XCOL21", "X251XCOL21", JdeDataType.String, 12),
        new JdeField("X251XCOL22", "X251XCOL22", JdeDataType.String, 12),
        new JdeField("X251XCOL23", "X251XCOL23", JdeDataType.String, 12),
        new JdeField("X251XCOL24", "X251XCOL24", JdeDataType.String, 12),
        new JdeField("X251XCOL25", "X251XCOL25", JdeDataType.String, 12),
        new JdeField("X251XCOL26", "X251XCOL26", JdeDataType.String, 12),
        new JdeField("X251XCOL27", "X251XCOL27", JdeDataType.String, 12),
        new JdeField("X251XCOL28", "X251XCOL28", JdeDataType.String, 12),
        new JdeField("X251XCOL29", "X251XCOL29", JdeDataType.String, 12),
        new JdeField("X251XCOL30", "X251XCOL30", JdeDataType.String, 12),
        new JdeField("X251XCOL31", "X251XCOL31", JdeDataType.String, 12),
        new JdeField("X251XCOL32", "X251XCOL32", JdeDataType.String, 12),
        new JdeField("X251XCOL33", "X251XCOL33", JdeDataType.String, 12),
        new JdeField("X251XCOL34", "X251XCOL34", JdeDataType.String, 12),
        new JdeField("X251XCOL35", "X251XCOL35", JdeDataType.String, 12),
        new JdeField("X251XCOL36", "X251XCOL36", JdeDataType.String, 12),
        new JdeField("X251XCOL37", "X251XCOL37", JdeDataType.String, 12),
        new JdeField("X251XCOL38", "X251XCOL38", JdeDataType.String, 12),
        new JdeField("X251XCOL39", "X251XCOL39", JdeDataType.String, 12),
        new JdeField("X251XCOL40", "X251XCOL40", JdeDataType.String, 12),
        new JdeField("X251X01IC", "X251X01IC", JdeDataType.String, 2),
        new JdeField("X251X02IC", "X251X02IC", JdeDataType.String, 2),
        new JdeField("X251X03IC", "X251X03IC", JdeDataType.String, 2),
        new JdeField("X251X04IC", "X251X04IC", JdeDataType.String, 2),
        new JdeField("X251X05IC", "X251X05IC", JdeDataType.String, 2),
        new JdeField("X251X06IC", "X251X06IC", JdeDataType.String, 2),
        new JdeField("X251X07IC", "X251X07IC", JdeDataType.String, 2),
        new JdeField("X251X08IC", "X251X08IC", JdeDataType.String, 2),
        new JdeField("X251X09IC", "X251X09IC", JdeDataType.String, 2),
        new JdeField("X251X10IC", "X251X10IC", JdeDataType.String, 2),
        new JdeField("X251X11IC", "X251X11IC", JdeDataType.String, 2),
        new JdeField("X251X12IC", "X251X12IC", JdeDataType.String, 2),
        new JdeField("X251X13IC", "X251X13IC", JdeDataType.String, 2),
        new JdeField("X251X14IC", "X251X14IC", JdeDataType.String, 2),
        new JdeField("X251X15IC", "X251X15IC", JdeDataType.String, 2),
        new JdeField("X251X16IC", "X251X16IC", JdeDataType.String, 2),
        new JdeField("X251X17IC", "X251X17IC", JdeDataType.String, 2),
        new JdeField("X251X18IC", "X251X18IC", JdeDataType.String, 2),
        new JdeField("X251X19IC", "X251X19IC", JdeDataType.String, 2),
        new JdeField("X251X20IC", "X251X20IC", JdeDataType.String, 2),
        new JdeField("X251X21IC", "X251X21IC", JdeDataType.String, 2),
        new JdeField("X251X22IC", "X251X22IC", JdeDataType.String, 2),
        new JdeField("X251X23IC", "X251X23IC", JdeDataType.String, 2),
        new JdeField("X251X24IC", "X251X24IC", JdeDataType.String, 2),
        new JdeField("X251X25IC", "X251X25IC", JdeDataType.String, 2),
        new JdeField("X251X26IC", "X251X26IC", JdeDataType.String, 2),
        new JdeField("X251X27IC", "X251X27IC", JdeDataType.String, 2),
        new JdeField("X251X28IC", "X251X28IC", JdeDataType.String, 2),
        new JdeField("X251X29IC", "X251X29IC", JdeDataType.String, 2),
        new JdeField("X251X30IC", "X251X30IC", JdeDataType.String, 2),
        new JdeField("X251X31IC", "X251X31IC", JdeDataType.String, 2),
        new JdeField("X251X32IC", "X251X32IC", JdeDataType.String, 2),
        new JdeField("X251X33IC", "X251X33IC", JdeDataType.String, 2),
        new JdeField("X251X34IC", "X251X34IC", JdeDataType.String, 2),
        new JdeField("X251X35IC", "X251X35IC", JdeDataType.String, 2),
        new JdeField("X251X36IC", "X251X36IC", JdeDataType.String, 2),
        new JdeField("X251X37IC", "X251X37IC", JdeDataType.String, 2),
        new JdeField("X251X38IC", "X251X38IC", JdeDataType.String, 2),
        new JdeField("X251X39IC", "X251X39IC", JdeDataType.String, 2),
        new JdeField("X251X40IC", "X251X40IC", JdeDataType.String, 2),
        new JdeField("X2USER", "X2USER", JdeDataType.String, 20),
        new JdeField("X2PID", "X2PID", JdeDataType.String, 20),
        new JdeField("X2JOB", "X2JOB", JdeDataType.String, 16),
        new JdeField("X2UPMJ", "X2UPMJ", JdeDataType.Numeric),
        new JdeField("X2UPMT", "X2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51X91_0", "Primary Key on X251XICL", new[] { "X251XICL" }, isUnique: true, isPrimaryKey: true)
    };
}
