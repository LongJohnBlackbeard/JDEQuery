using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15424 - .
/// </summary>
public class F15424 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THCO.
        /// </summary>
        public const string THCO = "THCO";

        /// <summary>
        /// THRRSQ1.
        /// </summary>
        public const string THRRSQ1 = "THRRSQ1";

        /// <summary>
        /// THRRSQ2.
        /// </summary>
        public const string THRRSQ2 = "THRRSQ2";

        /// <summary>
        /// THRRSQ3.
        /// </summary>
        public const string THRRSQ3 = "THRRSQ3";

        /// <summary>
        /// THRRSQ4.
        /// </summary>
        public const string THRRSQ4 = "THRRSQ4";

        /// <summary>
        /// THRRSQ5.
        /// </summary>
        public const string THRRSQ5 = "THRRSQ5";

        /// <summary>
        /// THRRSQ6.
        /// </summary>
        public const string THRRSQ6 = "THRRSQ6";

        /// <summary>
        /// THRRSQ7.
        /// </summary>
        public const string THRRSQ7 = "THRRSQ7";

        /// <summary>
        /// THRRSQ8.
        /// </summary>
        public const string THRRSQ8 = "THRRSQ8";

        /// <summary>
        /// THRRSQ9.
        /// </summary>
        public const string THRRSQ9 = "THRRSQ9";

        /// <summary>
        /// THRRSQ10.
        /// </summary>
        public const string THRRSQ10 = "THRRSQ10";

        /// <summary>
        /// THRRSQ11.
        /// </summary>
        public const string THRRSQ11 = "THRRSQ11";

        /// <summary>
        /// THRRSQ12.
        /// </summary>
        public const string THRRSQ12 = "THRRSQ12";

        /// <summary>
        /// THRRSQ13.
        /// </summary>
        public const string THRRSQ13 = "THRRSQ13";

        /// <summary>
        /// THRRSQ14.
        /// </summary>
        public const string THRRSQ14 = "THRRSQ14";

        /// <summary>
        /// THRRSQ15.
        /// </summary>
        public const string THRRSQ15 = "THRRSQ15";

        /// <summary>
        /// THRRSQ16.
        /// </summary>
        public const string THRRSQ16 = "THRRSQ16";

        /// <summary>
        /// THRRSQ17.
        /// </summary>
        public const string THRRSQ17 = "THRRSQ17";

        /// <summary>
        /// THRRSQ18.
        /// </summary>
        public const string THRRSQ18 = "THRRSQ18";

        /// <summary>
        /// THRRSQ18V.
        /// </summary>
        public const string THRRSQ18V = "THRRSQ18V";

        /// <summary>
        /// THRRSQ19.
        /// </summary>
        public const string THRRSQ19 = "THRRSQ19";

        /// <summary>
        /// THRRSQ19V.
        /// </summary>
        public const string THRRSQ19V = "THRRSQ19V";

        /// <summary>
        /// THRRSQ20.
        /// </summary>
        public const string THRRSQ20 = "THRRSQ20";

        /// <summary>
        /// THRRSQ20V.
        /// </summary>
        public const string THRRSQ20V = "THRRSQ20V";

        /// <summary>
        /// THRRSQ21.
        /// </summary>
        public const string THRRSQ21 = "THRRSQ21";

        /// <summary>
        /// THRRSQ21V.
        /// </summary>
        public const string THRRSQ21V = "THRRSQ21V";

        /// <summary>
        /// THRRSQ22.
        /// </summary>
        public const string THRRSQ22 = "THRRSQ22";

        /// <summary>
        /// THRRSQ22V.
        /// </summary>
        public const string THRRSQ22V = "THRRSQ22V";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THUPMT.
        /// </summary>
        public const string THUPMT = "THUPMT";

        /// <summary>
        /// THMKEY.
        /// </summary>
        public const string THMKEY = "THMKEY";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";
    }

    /// <inheritdoc />
    public override string TableName => "F15424";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THCO", "THCO", JdeDataType.String, 10, true, true),
        new JdeField("THRRSQ1", "THRRSQ1", JdeDataType.Numeric),
        new JdeField("THRRSQ2", "THRRSQ2", JdeDataType.Numeric),
        new JdeField("THRRSQ3", "THRRSQ3", JdeDataType.Numeric),
        new JdeField("THRRSQ4", "THRRSQ4", JdeDataType.Numeric),
        new JdeField("THRRSQ5", "THRRSQ5", JdeDataType.Numeric),
        new JdeField("THRRSQ6", "THRRSQ6", JdeDataType.Numeric),
        new JdeField("THRRSQ7", "THRRSQ7", JdeDataType.Numeric),
        new JdeField("THRRSQ8", "THRRSQ8", JdeDataType.Numeric),
        new JdeField("THRRSQ9", "THRRSQ9", JdeDataType.Numeric),
        new JdeField("THRRSQ10", "THRRSQ10", JdeDataType.Numeric),
        new JdeField("THRRSQ11", "THRRSQ11", JdeDataType.Numeric),
        new JdeField("THRRSQ12", "THRRSQ12", JdeDataType.Numeric),
        new JdeField("THRRSQ13", "THRRSQ13", JdeDataType.Numeric),
        new JdeField("THRRSQ14", "THRRSQ14", JdeDataType.Numeric),
        new JdeField("THRRSQ15", "THRRSQ15", JdeDataType.Numeric),
        new JdeField("THRRSQ16", "THRRSQ16", JdeDataType.Numeric),
        new JdeField("THRRSQ17", "THRRSQ17", JdeDataType.Numeric),
        new JdeField("THRRSQ18", "THRRSQ18", JdeDataType.Numeric),
        new JdeField("THRRSQ18V", "THRRSQ18V", JdeDataType.Numeric),
        new JdeField("THRRSQ19", "THRRSQ19", JdeDataType.Numeric),
        new JdeField("THRRSQ19V", "THRRSQ19V", JdeDataType.Numeric),
        new JdeField("THRRSQ20", "THRRSQ20", JdeDataType.Numeric),
        new JdeField("THRRSQ20V", "THRRSQ20V", JdeDataType.Numeric),
        new JdeField("THRRSQ21", "THRRSQ21", JdeDataType.Numeric),
        new JdeField("THRRSQ21V", "THRRSQ21V", JdeDataType.Numeric),
        new JdeField("THRRSQ22", "THRRSQ22", JdeDataType.Numeric),
        new JdeField("THRRSQ22V", "THRRSQ22V", JdeDataType.Numeric),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THUPMT", "THUPMT", JdeDataType.Numeric),
        new JdeField("THMKEY", "THMKEY", JdeDataType.String, 30),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15424_0", "Primary Key on THCO", new[] { "THCO" }, isUnique: true, isPrimaryKey: true)
    };
}
