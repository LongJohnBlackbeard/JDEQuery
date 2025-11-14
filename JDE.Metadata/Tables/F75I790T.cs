using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I790T - .
/// </summary>
public class F75I790T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SFAN8.
        /// </summary>
        public const string SFAN8 = "SFAN8";

        /// <summary>
        /// SFFYR.
        /// </summary>
        public const string SFFYR = "SFFYR";

        /// <summary>
        /// SFEV01.
        /// </summary>
        public const string SFEV01 = "SFEV01";

        /// <summary>
        /// SFMT.
        /// </summary>
        public const string SFMT = "SFMT";

        /// <summary>
        /// SFEV02.
        /// </summary>
        public const string SFEV02 = "SFEV02";

        /// <summary>
        /// SFEV03.
        /// </summary>
        public const string SFEV03 = "SFEV03";

        /// <summary>
        /// SFEV04.
        /// </summary>
        public const string SFEV04 = "SFEV04";

        /// <summary>
        /// SFEV05.
        /// </summary>
        public const string SFEV05 = "SFEV05";

        /// <summary>
        /// SFPLPRICE1.
        /// </summary>
        public const string SFPLPRICE1 = "SFPLPRICE1";

        /// <summary>
        /// SFPLPRICE2.
        /// </summary>
        public const string SFPLPRICE2 = "SFPLPRICE2";

        /// <summary>
        /// SFPLPRICE3.
        /// </summary>
        public const string SFPLPRICE3 = "SFPLPRICE3";

        /// <summary>
        /// SFPLPRICE4.
        /// </summary>
        public const string SFPLPRICE4 = "SFPLPRICE4";

        /// <summary>
        /// SFI75CHDT.
        /// </summary>
        public const string SFI75CHDT = "SFI75CHDT";

        /// <summary>
        /// SFI75CHNO.
        /// </summary>
        public const string SFI75CHNO = "SFI75CHNO";
    }

    /// <inheritdoc />
    public override string TableName => "F75I790T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SFAN8", "SFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SFFYR", "SFFYR", JdeDataType.Numeric, null, true, true),
        new JdeField("SFEV01", "SFEV01", JdeDataType.String, 2, true, true),
        new JdeField("SFMT", "SFMT", JdeDataType.Numeric, null, true, true),
        new JdeField("SFEV02", "SFEV02", JdeDataType.String, 2),
        new JdeField("SFEV03", "SFEV03", JdeDataType.String, 2),
        new JdeField("SFEV04", "SFEV04", JdeDataType.String, 2),
        new JdeField("SFEV05", "SFEV05", JdeDataType.String, 2),
        new JdeField("SFPLPRICE1", "SFPLPRICE1", JdeDataType.Numeric),
        new JdeField("SFPLPRICE2", "SFPLPRICE2", JdeDataType.Numeric),
        new JdeField("SFPLPRICE3", "SFPLPRICE3", JdeDataType.Numeric),
        new JdeField("SFPLPRICE4", "SFPLPRICE4", JdeDataType.Numeric),
        new JdeField("SFI75CHDT", "SFI75CHDT", JdeDataType.Numeric),
        new JdeField("SFI75CHNO", "SFI75CHNO", JdeDataType.String, 120)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I790T_0", "Primary Key on SFAN8, SFFYR, SFEV01, SFMT", new[] { "SFAN8", "SFFYR", "SFEV01", "SFMT" }, isUnique: true, isPrimaryKey: true)
    };
}
