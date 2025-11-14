using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C912 - .
/// </summary>
public class F75C912 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TSKCO.
        /// </summary>
        public const string TSKCO = "TSKCO";

        /// <summary>
        /// TSDCT.
        /// </summary>
        public const string TSDCT = "TSDCT";

        /// <summary>
        /// TSDOC.
        /// </summary>
        public const string TSDOC = "TSDOC";

        /// <summary>
        /// TSDGJ.
        /// </summary>
        public const string TSDGJ = "TSDGJ";

        /// <summary>
        /// TSLT.
        /// </summary>
        public const string TSLT = "TSLT";

        /// <summary>
        /// TSJELN.
        /// </summary>
        public const string TSJELN = "TSJELN";

        /// <summary>
        /// TSEXTL.
        /// </summary>
        public const string TSEXTL = "TSEXTL";

        /// <summary>
        /// TSC75TRTP.
        /// </summary>
        public const string TSC75TRTP = "TSC75TRTP";

        /// <summary>
        /// TSC75SUB1.
        /// </summary>
        public const string TSC75SUB1 = "TSC75SUB1";

        /// <summary>
        /// TSC75SUB2.
        /// </summary>
        public const string TSC75SUB2 = "TSC75SUB2";

        /// <summary>
        /// TSC75SUB3.
        /// </summary>
        public const string TSC75SUB3 = "TSC75SUB3";

        /// <summary>
        /// TSC75SUB4.
        /// </summary>
        public const string TSC75SUB4 = "TSC75SUB4";

        /// <summary>
        /// TSC75SUB5.
        /// </summary>
        public const string TSC75SUB5 = "TSC75SUB5";

        /// <summary>
        /// TSC75SUB6.
        /// </summary>
        public const string TSC75SUB6 = "TSC75SUB6";

        /// <summary>
        /// TSC75SUB7.
        /// </summary>
        public const string TSC75SUB7 = "TSC75SUB7";

        /// <summary>
        /// TSC75SUB8.
        /// </summary>
        public const string TSC75SUB8 = "TSC75SUB8";

        /// <summary>
        /// TSC75SUB9.
        /// </summary>
        public const string TSC75SUB9 = "TSC75SUB9";

        /// <summary>
        /// TSC75SUB10.
        /// </summary>
        public const string TSC75SUB10 = "TSC75SUB10";

        /// <summary>
        /// TSC75SUB11.
        /// </summary>
        public const string TSC75SUB11 = "TSC75SUB11";

        /// <summary>
        /// TSC75SUB12.
        /// </summary>
        public const string TSC75SUB12 = "TSC75SUB12";

        /// <summary>
        /// TSC75SUB13.
        /// </summary>
        public const string TSC75SUB13 = "TSC75SUB13";

        /// <summary>
        /// TSC75SUB14.
        /// </summary>
        public const string TSC75SUB14 = "TSC75SUB14";

        /// <summary>
        /// TSC75SUB15.
        /// </summary>
        public const string TSC75SUB15 = "TSC75SUB15";

        /// <summary>
        /// TSC75SUB16.
        /// </summary>
        public const string TSC75SUB16 = "TSC75SUB16";

        /// <summary>
        /// TSC75SUB17.
        /// </summary>
        public const string TSC75SUB17 = "TSC75SUB17";

        /// <summary>
        /// TSC75SUB18.
        /// </summary>
        public const string TSC75SUB18 = "TSC75SUB18";

        /// <summary>
        /// TSC75SUB19.
        /// </summary>
        public const string TSC75SUB19 = "TSC75SUB19";

        /// <summary>
        /// TSC75SUB20.
        /// </summary>
        public const string TSC75SUB20 = "TSC75SUB20";

        /// <summary>
        /// TSC75SUB21.
        /// </summary>
        public const string TSC75SUB21 = "TSC75SUB21";

        /// <summary>
        /// TSC75SUB22.
        /// </summary>
        public const string TSC75SUB22 = "TSC75SUB22";

        /// <summary>
        /// TSC75SUB23.
        /// </summary>
        public const string TSC75SUB23 = "TSC75SUB23";

        /// <summary>
        /// TSC75SUB24.
        /// </summary>
        public const string TSC75SUB24 = "TSC75SUB24";

        /// <summary>
        /// TSC75SUB25.
        /// </summary>
        public const string TSC75SUB25 = "TSC75SUB25";

        /// <summary>
        /// TSC75SUB26.
        /// </summary>
        public const string TSC75SUB26 = "TSC75SUB26";

        /// <summary>
        /// TSC75SUB27.
        /// </summary>
        public const string TSC75SUB27 = "TSC75SUB27";

        /// <summary>
        /// TSC75SUB28.
        /// </summary>
        public const string TSC75SUB28 = "TSC75SUB28";

        /// <summary>
        /// TSC75SUB29.
        /// </summary>
        public const string TSC75SUB29 = "TSC75SUB29";

        /// <summary>
        /// TSC75SUB30.
        /// </summary>
        public const string TSC75SUB30 = "TSC75SUB30";

        /// <summary>
        /// TSPID.
        /// </summary>
        public const string TSPID = "TSPID";

        /// <summary>
        /// TSUSER.
        /// </summary>
        public const string TSUSER = "TSUSER";

        /// <summary>
        /// TSJOBN.
        /// </summary>
        public const string TSJOBN = "TSJOBN";

        /// <summary>
        /// TSUPMJ.
        /// </summary>
        public const string TSUPMJ = "TSUPMJ";

        /// <summary>
        /// TSUPMT.
        /// </summary>
        public const string TSUPMT = "TSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C912";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSKCO", "TSKCO", JdeDataType.String, 10, true, true),
        new JdeField("TSDCT", "TSDCT", JdeDataType.String, 4, true, true),
        new JdeField("TSDOC", "TSDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TSDGJ", "TSDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TSLT", "TSLT", JdeDataType.String, 4, true, true),
        new JdeField("TSJELN", "TSJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("TSEXTL", "TSEXTL", JdeDataType.String, 4, true, true),
        new JdeField("TSC75TRTP", "TSC75TRTP", JdeDataType.String, 2),
        new JdeField("TSC75SUB1", "TSC75SUB1", JdeDataType.String, 120),
        new JdeField("TSC75SUB2", "TSC75SUB2", JdeDataType.String, 120),
        new JdeField("TSC75SUB3", "TSC75SUB3", JdeDataType.String, 120),
        new JdeField("TSC75SUB4", "TSC75SUB4", JdeDataType.String, 120),
        new JdeField("TSC75SUB5", "TSC75SUB5", JdeDataType.String, 120),
        new JdeField("TSC75SUB6", "TSC75SUB6", JdeDataType.String, 120),
        new JdeField("TSC75SUB7", "TSC75SUB7", JdeDataType.String, 120),
        new JdeField("TSC75SUB8", "TSC75SUB8", JdeDataType.String, 120),
        new JdeField("TSC75SUB9", "TSC75SUB9", JdeDataType.String, 120),
        new JdeField("TSC75SUB10", "TSC75SUB10", JdeDataType.String, 120),
        new JdeField("TSC75SUB11", "TSC75SUB11", JdeDataType.String, 120),
        new JdeField("TSC75SUB12", "TSC75SUB12", JdeDataType.String, 120),
        new JdeField("TSC75SUB13", "TSC75SUB13", JdeDataType.String, 120),
        new JdeField("TSC75SUB14", "TSC75SUB14", JdeDataType.String, 120),
        new JdeField("TSC75SUB15", "TSC75SUB15", JdeDataType.String, 120),
        new JdeField("TSC75SUB16", "TSC75SUB16", JdeDataType.String, 120),
        new JdeField("TSC75SUB17", "TSC75SUB17", JdeDataType.String, 120),
        new JdeField("TSC75SUB18", "TSC75SUB18", JdeDataType.String, 120),
        new JdeField("TSC75SUB19", "TSC75SUB19", JdeDataType.String, 120),
        new JdeField("TSC75SUB20", "TSC75SUB20", JdeDataType.String, 120),
        new JdeField("TSC75SUB21", "TSC75SUB21", JdeDataType.String, 120),
        new JdeField("TSC75SUB22", "TSC75SUB22", JdeDataType.String, 120),
        new JdeField("TSC75SUB23", "TSC75SUB23", JdeDataType.String, 120),
        new JdeField("TSC75SUB24", "TSC75SUB24", JdeDataType.String, 120),
        new JdeField("TSC75SUB25", "TSC75SUB25", JdeDataType.String, 120),
        new JdeField("TSC75SUB26", "TSC75SUB26", JdeDataType.String, 120),
        new JdeField("TSC75SUB27", "TSC75SUB27", JdeDataType.String, 120),
        new JdeField("TSC75SUB28", "TSC75SUB28", JdeDataType.String, 120),
        new JdeField("TSC75SUB29", "TSC75SUB29", JdeDataType.String, 120),
        new JdeField("TSC75SUB30", "TSC75SUB30", JdeDataType.String, 120),
        new JdeField("TSPID", "TSPID", JdeDataType.String, 20),
        new JdeField("TSUSER", "TSUSER", JdeDataType.String, 20),
        new JdeField("TSJOBN", "TSJOBN", JdeDataType.String, 20),
        new JdeField("TSUPMJ", "TSUPMJ", JdeDataType.Numeric),
        new JdeField("TSUPMT", "TSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C912_0", "Primary Key on TSDCT, TSDOC, TSKCO, TSDGJ, TSJELN, TSLT, TSEXTL", new[] { "TSDCT", "TSDOC", "TSKCO", "TSDGJ", "TSJELN", "TSLT", "TSEXTL" }, isUnique: true, isPrimaryKey: true)
    };
}
