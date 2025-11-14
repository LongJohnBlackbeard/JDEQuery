using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08124 - .
/// </summary>
public class F08124 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMRPYR.
        /// </summary>
        public const string WMRPYR = "WMRPYR";

        /// <summary>
        /// WMAN8.
        /// </summary>
        public const string WMAN8 = "WMAN8";

        /// <summary>
        /// WMHMCO.
        /// </summary>
        public const string WMHMCO = "WMHMCO";

        /// <summary>
        /// WMTAXX.
        /// </summary>
        public const string WMTAXX = "WMTAXX";

        /// <summary>
        /// WMMW01.
        /// </summary>
        public const string WMMW01 = "WMMW01";

        /// <summary>
        /// WMMW02.
        /// </summary>
        public const string WMMW02 = "WMMW02";

        /// <summary>
        /// WMMW03.
        /// </summary>
        public const string WMMW03 = "WMMW03";

        /// <summary>
        /// WMMW04.
        /// </summary>
        public const string WMMW04 = "WMMW04";

        /// <summary>
        /// WMMW05.
        /// </summary>
        public const string WMMW05 = "WMMW05";

        /// <summary>
        /// WMMW06.
        /// </summary>
        public const string WMMW06 = "WMMW06";

        /// <summary>
        /// WMMW07.
        /// </summary>
        public const string WMMW07 = "WMMW07";

        /// <summary>
        /// WMMW08.
        /// </summary>
        public const string WMMW08 = "WMMW08";

        /// <summary>
        /// WMMW09.
        /// </summary>
        public const string WMMW09 = "WMMW09";

        /// <summary>
        /// WMMW10.
        /// </summary>
        public const string WMMW10 = "WMMW10";

        /// <summary>
        /// WMMW11.
        /// </summary>
        public const string WMMW11 = "WMMW11";

        /// <summary>
        /// WMMW12.
        /// </summary>
        public const string WMMW12 = "WMMW12";

        /// <summary>
        /// WMSPASUSI1.
        /// </summary>
        public const string WMSPASUSI1 = "WMSPASUSI1";

        /// <summary>
        /// WMSPASUSI2.
        /// </summary>
        public const string WMSPASUSI2 = "WMSPASUSI2";

        /// <summary>
        /// WMSPASUSI3.
        /// </summary>
        public const string WMSPASUSI3 = "WMSPASUSI3";

        /// <summary>
        /// WMSPASUSI4.
        /// </summary>
        public const string WMSPASUSI4 = "WMSPASUSI4";

        /// <summary>
        /// WMSPANUSI1.
        /// </summary>
        public const string WMSPANUSI1 = "WMSPANUSI1";

        /// <summary>
        /// WMSPANUSI2.
        /// </summary>
        public const string WMSPANUSI2 = "WMSPANUSI2";

        /// <summary>
        /// WMSPANUSI3.
        /// </summary>
        public const string WMSPANUSI3 = "WMSPANUSI3";

        /// <summary>
        /// WMSPANUSI4.
        /// </summary>
        public const string WMSPANUSI4 = "WMSPANUSI4";

        /// <summary>
        /// WMSPADUSI1.
        /// </summary>
        public const string WMSPADUSI1 = "WMSPADUSI1";

        /// <summary>
        /// WMSPADUSI2.
        /// </summary>
        public const string WMSPADUSI2 = "WMSPADUSI2";

        /// <summary>
        /// WMSPADUSI3.
        /// </summary>
        public const string WMSPADUSI3 = "WMSPADUSI3";

        /// <summary>
        /// WMSPADUSI4.
        /// </summary>
        public const string WMSPADUSI4 = "WMSPADUSI4";

        /// <summary>
        /// WMSPACUSI1.
        /// </summary>
        public const string WMSPACUSI1 = "WMSPACUSI1";

        /// <summary>
        /// WMSPACUSI2.
        /// </summary>
        public const string WMSPACUSI2 = "WMSPACUSI2";

        /// <summary>
        /// WMSPACUSI3.
        /// </summary>
        public const string WMSPACUSI3 = "WMSPACUSI3";

        /// <summary>
        /// WMSPACUSI4.
        /// </summary>
        public const string WMSPACUSI4 = "WMSPACUSI4";

        /// <summary>
        /// WMUSER.
        /// </summary>
        public const string WMUSER = "WMUSER";

        /// <summary>
        /// WMPID.
        /// </summary>
        public const string WMPID = "WMPID";

        /// <summary>
        /// WMJOBN.
        /// </summary>
        public const string WMJOBN = "WMJOBN";

        /// <summary>
        /// WMUPMJ.
        /// </summary>
        public const string WMUPMJ = "WMUPMJ";

        /// <summary>
        /// WMUPMT.
        /// </summary>
        public const string WMUPMT = "WMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08124";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMRPYR", "WMRPYR", JdeDataType.Numeric, null, true, true),
        new JdeField("WMAN8", "WMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WMHMCO", "WMHMCO", JdeDataType.String, 10, true, true),
        new JdeField("WMTAXX", "WMTAXX", JdeDataType.String, 40, true, true),
        new JdeField("WMMW01", "WMMW01", JdeDataType.Numeric),
        new JdeField("WMMW02", "WMMW02", JdeDataType.Numeric),
        new JdeField("WMMW03", "WMMW03", JdeDataType.Numeric),
        new JdeField("WMMW04", "WMMW04", JdeDataType.Numeric),
        new JdeField("WMMW05", "WMMW05", JdeDataType.Numeric),
        new JdeField("WMMW06", "WMMW06", JdeDataType.Numeric),
        new JdeField("WMMW07", "WMMW07", JdeDataType.Numeric),
        new JdeField("WMMW08", "WMMW08", JdeDataType.Numeric),
        new JdeField("WMMW09", "WMMW09", JdeDataType.Numeric),
        new JdeField("WMMW10", "WMMW10", JdeDataType.Numeric),
        new JdeField("WMMW11", "WMMW11", JdeDataType.Numeric),
        new JdeField("WMMW12", "WMMW12", JdeDataType.Numeric),
        new JdeField("WMSPASUSI1", "WMSPASUSI1", JdeDataType.String, 60),
        new JdeField("WMSPASUSI2", "WMSPASUSI2", JdeDataType.String, 60),
        new JdeField("WMSPASUSI3", "WMSPASUSI3", JdeDataType.String, 60),
        new JdeField("WMSPASUSI4", "WMSPASUSI4", JdeDataType.String, 60),
        new JdeField("WMSPANUSI1", "WMSPANUSI1", JdeDataType.Numeric),
        new JdeField("WMSPANUSI2", "WMSPANUSI2", JdeDataType.Numeric),
        new JdeField("WMSPANUSI3", "WMSPANUSI3", JdeDataType.Numeric),
        new JdeField("WMSPANUSI4", "WMSPANUSI4", JdeDataType.Numeric),
        new JdeField("WMSPADUSI1", "WMSPADUSI1", JdeDataType.Numeric),
        new JdeField("WMSPADUSI2", "WMSPADUSI2", JdeDataType.Numeric),
        new JdeField("WMSPADUSI3", "WMSPADUSI3", JdeDataType.Numeric),
        new JdeField("WMSPADUSI4", "WMSPADUSI4", JdeDataType.Numeric),
        new JdeField("WMSPACUSI1", "WMSPACUSI1", JdeDataType.String, 2),
        new JdeField("WMSPACUSI2", "WMSPACUSI2", JdeDataType.String, 2),
        new JdeField("WMSPACUSI3", "WMSPACUSI3", JdeDataType.String, 2),
        new JdeField("WMSPACUSI4", "WMSPACUSI4", JdeDataType.String, 2),
        new JdeField("WMUSER", "WMUSER", JdeDataType.String, 20),
        new JdeField("WMPID", "WMPID", JdeDataType.String, 20),
        new JdeField("WMJOBN", "WMJOBN", JdeDataType.String, 20),
        new JdeField("WMUPMJ", "WMUPMJ", JdeDataType.Numeric),
        new JdeField("WMUPMT", "WMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08124_0", "Primary Key on WMRPYR, WMAN8, WMHMCO, WMTAXX", new[] { "WMRPYR", "WMAN8", "WMHMCO", "WMTAXX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08124_2", "Index on WMRPYR, WMAN8, WMTAXX, WMHMCO", new[] { "WMRPYR", "WMAN8", "WMTAXX", "WMHMCO" })
    };
}
