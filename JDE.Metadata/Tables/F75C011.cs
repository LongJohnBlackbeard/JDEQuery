using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C011 - .
/// </summary>
public class F75C011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UVAID.
        /// </summary>
        public const string UVAID = "UVAID";

        /// <summary>
        /// UVC75SUB1.
        /// </summary>
        public const string UVC75SUB1 = "UVC75SUB1";

        /// <summary>
        /// UVC75SUB2.
        /// </summary>
        public const string UVC75SUB2 = "UVC75SUB2";

        /// <summary>
        /// UVC75SUB3.
        /// </summary>
        public const string UVC75SUB3 = "UVC75SUB3";

        /// <summary>
        /// UVC75SUB4.
        /// </summary>
        public const string UVC75SUB4 = "UVC75SUB4";

        /// <summary>
        /// UVC75SUB5.
        /// </summary>
        public const string UVC75SUB5 = "UVC75SUB5";

        /// <summary>
        /// UVC75SUB6.
        /// </summary>
        public const string UVC75SUB6 = "UVC75SUB6";

        /// <summary>
        /// UVC75SUB7.
        /// </summary>
        public const string UVC75SUB7 = "UVC75SUB7";

        /// <summary>
        /// UVC75SUB8.
        /// </summary>
        public const string UVC75SUB8 = "UVC75SUB8";

        /// <summary>
        /// UVC75SUB9.
        /// </summary>
        public const string UVC75SUB9 = "UVC75SUB9";

        /// <summary>
        /// UVC75SUB10.
        /// </summary>
        public const string UVC75SUB10 = "UVC75SUB10";

        /// <summary>
        /// UVC75SUB11.
        /// </summary>
        public const string UVC75SUB11 = "UVC75SUB11";

        /// <summary>
        /// UVC75SUB12.
        /// </summary>
        public const string UVC75SUB12 = "UVC75SUB12";

        /// <summary>
        /// UVC75SUB13.
        /// </summary>
        public const string UVC75SUB13 = "UVC75SUB13";

        /// <summary>
        /// UVC75SUB14.
        /// </summary>
        public const string UVC75SUB14 = "UVC75SUB14";

        /// <summary>
        /// UVC75SUB15.
        /// </summary>
        public const string UVC75SUB15 = "UVC75SUB15";

        /// <summary>
        /// UVC75SUB16.
        /// </summary>
        public const string UVC75SUB16 = "UVC75SUB16";

        /// <summary>
        /// UVC75SUB17.
        /// </summary>
        public const string UVC75SUB17 = "UVC75SUB17";

        /// <summary>
        /// UVC75SUB18.
        /// </summary>
        public const string UVC75SUB18 = "UVC75SUB18";

        /// <summary>
        /// UVC75SUB19.
        /// </summary>
        public const string UVC75SUB19 = "UVC75SUB19";

        /// <summary>
        /// UVC75SUB20.
        /// </summary>
        public const string UVC75SUB20 = "UVC75SUB20";

        /// <summary>
        /// UVC75SUB21.
        /// </summary>
        public const string UVC75SUB21 = "UVC75SUB21";

        /// <summary>
        /// UVC75SUB22.
        /// </summary>
        public const string UVC75SUB22 = "UVC75SUB22";

        /// <summary>
        /// UVC75SUB23.
        /// </summary>
        public const string UVC75SUB23 = "UVC75SUB23";

        /// <summary>
        /// UVC75SUB24.
        /// </summary>
        public const string UVC75SUB24 = "UVC75SUB24";

        /// <summary>
        /// UVC75SUB25.
        /// </summary>
        public const string UVC75SUB25 = "UVC75SUB25";

        /// <summary>
        /// UVC75SUB26.
        /// </summary>
        public const string UVC75SUB26 = "UVC75SUB26";

        /// <summary>
        /// UVC75SUB27.
        /// </summary>
        public const string UVC75SUB27 = "UVC75SUB27";

        /// <summary>
        /// UVC75SUB28.
        /// </summary>
        public const string UVC75SUB28 = "UVC75SUB28";

        /// <summary>
        /// UVC75SUB29.
        /// </summary>
        public const string UVC75SUB29 = "UVC75SUB29";

        /// <summary>
        /// UVC75SUB30.
        /// </summary>
        public const string UVC75SUB30 = "UVC75SUB30";

        /// <summary>
        /// UVUSER.
        /// </summary>
        public const string UVUSER = "UVUSER";

        /// <summary>
        /// UVPID.
        /// </summary>
        public const string UVPID = "UVPID";

        /// <summary>
        /// UVUPMJ.
        /// </summary>
        public const string UVUPMJ = "UVUPMJ";

        /// <summary>
        /// UVUPMT.
        /// </summary>
        public const string UVUPMT = "UVUPMT";

        /// <summary>
        /// UVJOBN.
        /// </summary>
        public const string UVJOBN = "UVJOBN";

        /// <summary>
        /// UVFUTMATH1.
        /// </summary>
        public const string UVFUTMATH1 = "UVFUTMATH1";

        /// <summary>
        /// UVFUTSTR2.
        /// </summary>
        public const string UVFUTSTR2 = "UVFUTSTR2";

        /// <summary>
        /// UVFUTDATE1.
        /// </summary>
        public const string UVFUTDATE1 = "UVFUTDATE1";

        /// <summary>
        /// UVFUTUO1.
        /// </summary>
        public const string UVFUTUO1 = "UVFUTUO1";
    }

    /// <inheritdoc />
    public override string TableName => "F75C011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UVAID", "UVAID", JdeDataType.String, 16, true, true),
        new JdeField("UVC75SUB1", "UVC75SUB1", JdeDataType.String, 120),
        new JdeField("UVC75SUB2", "UVC75SUB2", JdeDataType.String, 120),
        new JdeField("UVC75SUB3", "UVC75SUB3", JdeDataType.String, 120),
        new JdeField("UVC75SUB4", "UVC75SUB4", JdeDataType.String, 120),
        new JdeField("UVC75SUB5", "UVC75SUB5", JdeDataType.String, 120),
        new JdeField("UVC75SUB6", "UVC75SUB6", JdeDataType.String, 120),
        new JdeField("UVC75SUB7", "UVC75SUB7", JdeDataType.String, 120),
        new JdeField("UVC75SUB8", "UVC75SUB8", JdeDataType.String, 120),
        new JdeField("UVC75SUB9", "UVC75SUB9", JdeDataType.String, 120),
        new JdeField("UVC75SUB10", "UVC75SUB10", JdeDataType.String, 120),
        new JdeField("UVC75SUB11", "UVC75SUB11", JdeDataType.String, 120),
        new JdeField("UVC75SUB12", "UVC75SUB12", JdeDataType.String, 120),
        new JdeField("UVC75SUB13", "UVC75SUB13", JdeDataType.String, 120),
        new JdeField("UVC75SUB14", "UVC75SUB14", JdeDataType.String, 120),
        new JdeField("UVC75SUB15", "UVC75SUB15", JdeDataType.String, 120),
        new JdeField("UVC75SUB16", "UVC75SUB16", JdeDataType.String, 120),
        new JdeField("UVC75SUB17", "UVC75SUB17", JdeDataType.String, 120),
        new JdeField("UVC75SUB18", "UVC75SUB18", JdeDataType.String, 120),
        new JdeField("UVC75SUB19", "UVC75SUB19", JdeDataType.String, 120),
        new JdeField("UVC75SUB20", "UVC75SUB20", JdeDataType.String, 120),
        new JdeField("UVC75SUB21", "UVC75SUB21", JdeDataType.String, 120),
        new JdeField("UVC75SUB22", "UVC75SUB22", JdeDataType.String, 120),
        new JdeField("UVC75SUB23", "UVC75SUB23", JdeDataType.String, 120),
        new JdeField("UVC75SUB24", "UVC75SUB24", JdeDataType.String, 120),
        new JdeField("UVC75SUB25", "UVC75SUB25", JdeDataType.String, 120),
        new JdeField("UVC75SUB26", "UVC75SUB26", JdeDataType.String, 120),
        new JdeField("UVC75SUB27", "UVC75SUB27", JdeDataType.String, 120),
        new JdeField("UVC75SUB28", "UVC75SUB28", JdeDataType.String, 120),
        new JdeField("UVC75SUB29", "UVC75SUB29", JdeDataType.String, 120),
        new JdeField("UVC75SUB30", "UVC75SUB30", JdeDataType.String, 120),
        new JdeField("UVUSER", "UVUSER", JdeDataType.String, 20),
        new JdeField("UVPID", "UVPID", JdeDataType.String, 20),
        new JdeField("UVUPMJ", "UVUPMJ", JdeDataType.Numeric),
        new JdeField("UVUPMT", "UVUPMT", JdeDataType.Numeric),
        new JdeField("UVJOBN", "UVJOBN", JdeDataType.String, 20),
        new JdeField("UVFUTMATH1", "UVFUTMATH1", JdeDataType.Numeric),
        new JdeField("UVFUTSTR2", "UVFUTSTR2", JdeDataType.String, 100),
        new JdeField("UVFUTDATE1", "UVFUTDATE1", JdeDataType.Numeric),
        new JdeField("UVFUTUO1", "UVFUTUO1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C011_0", "Primary Key on UVAID", new[] { "UVAID" }, isUnique: true, isPrimaryKey: true)
    };
}
