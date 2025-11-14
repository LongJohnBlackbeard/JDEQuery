using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0740 - .
/// </summary>
public class F31B0740 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PAEURID.
        /// </summary>
        public const string PAEURID = "PAEURID";

        /// <summary>
        /// PAMCU.
        /// </summary>
        public const string PAMCU = "PAMCU";

        /// <summary>
        /// PAACTIVITY.
        /// </summary>
        public const string PAACTIVITY = "PAACTIVITY";

        /// <summary>
        /// PAPLNTYP.
        /// </summary>
        public const string PAPLNTYP = "PAPLNTYP";

        /// <summary>
        /// PAPBEGDT.
        /// </summary>
        public const string PAPBEGDT = "PAPBEGDT";

        /// <summary>
        /// PAPENDDT.
        /// </summary>
        public const string PAPENDDT = "PAPENDDT";

        /// <summary>
        /// PAPQA1.
        /// </summary>
        public const string PAPQA1 = "PAPQA1";

        /// <summary>
        /// PAPQA2.
        /// </summary>
        public const string PAPQA2 = "PAPQA2";

        /// <summary>
        /// PAPQA3.
        /// </summary>
        public const string PAPQA3 = "PAPQA3";

        /// <summary>
        /// PAPQA4.
        /// </summary>
        public const string PAPQA4 = "PAPQA4";

        /// <summary>
        /// PAPQA5.
        /// </summary>
        public const string PAPQA5 = "PAPQA5";

        /// <summary>
        /// PAPQA6.
        /// </summary>
        public const string PAPQA6 = "PAPQA6";

        /// <summary>
        /// PAPQA7.
        /// </summary>
        public const string PAPQA7 = "PAPQA7";

        /// <summary>
        /// PAPQA8.
        /// </summary>
        public const string PAPQA8 = "PAPQA8";

        /// <summary>
        /// PAPQA9.
        /// </summary>
        public const string PAPQA9 = "PAPQA9";

        /// <summary>
        /// PAPQA10.
        /// </summary>
        public const string PAPQA10 = "PAPQA10";

        /// <summary>
        /// PAPUOM1.
        /// </summary>
        public const string PAPUOM1 = "PAPUOM1";

        /// <summary>
        /// PAPUOM2.
        /// </summary>
        public const string PAPUOM2 = "PAPUOM2";

        /// <summary>
        /// PAPUOM3.
        /// </summary>
        public const string PAPUOM3 = "PAPUOM3";

        /// <summary>
        /// PAPUOM4.
        /// </summary>
        public const string PAPUOM4 = "PAPUOM4";

        /// <summary>
        /// PAPUOM5.
        /// </summary>
        public const string PAPUOM5 = "PAPUOM5";

        /// <summary>
        /// PAPUOM6.
        /// </summary>
        public const string PAPUOM6 = "PAPUOM6";

        /// <summary>
        /// PAPUOM7.
        /// </summary>
        public const string PAPUOM7 = "PAPUOM7";

        /// <summary>
        /// PAPUOM8.
        /// </summary>
        public const string PAPUOM8 = "PAPUOM8";

        /// <summary>
        /// PAPUOM9.
        /// </summary>
        public const string PAPUOM9 = "PAPUOM9";

        /// <summary>
        /// PAPUOM10.
        /// </summary>
        public const string PAPUOM10 = "PAPUOM10";

        /// <summary>
        /// PAPQC1.
        /// </summary>
        public const string PAPQC1 = "PAPQC1";

        /// <summary>
        /// PAPQC2.
        /// </summary>
        public const string PAPQC2 = "PAPQC2";

        /// <summary>
        /// PAPQC3.
        /// </summary>
        public const string PAPQC3 = "PAPQC3";

        /// <summary>
        /// PAPQC4.
        /// </summary>
        public const string PAPQC4 = "PAPQC4";

        /// <summary>
        /// PAPQC5.
        /// </summary>
        public const string PAPQC5 = "PAPQC5";

        /// <summary>
        /// PAPQC6.
        /// </summary>
        public const string PAPQC6 = "PAPQC6";

        /// <summary>
        /// PAPQC7.
        /// </summary>
        public const string PAPQC7 = "PAPQC7";

        /// <summary>
        /// PAPQC8.
        /// </summary>
        public const string PAPQC8 = "PAPQC8";

        /// <summary>
        /// PAPQC9.
        /// </summary>
        public const string PAPQC9 = "PAPQC9";

        /// <summary>
        /// PAPQC10.
        /// </summary>
        public const string PAPQC10 = "PAPQC10";

        /// <summary>
        /// PAURAB.
        /// </summary>
        public const string PAURAB = "PAURAB";

        /// <summary>
        /// PAURAT.
        /// </summary>
        public const string PAURAT = "PAURAT";

        /// <summary>
        /// PAURCD.
        /// </summary>
        public const string PAURCD = "PAURCD";

        /// <summary>
        /// PAURDT.
        /// </summary>
        public const string PAURDT = "PAURDT";

        /// <summary>
        /// PAURRF.
        /// </summary>
        public const string PAURRF = "PAURRF";

        /// <summary>
        /// PAJOBN.
        /// </summary>
        public const string PAJOBN = "PAJOBN";

        /// <summary>
        /// PAPID.
        /// </summary>
        public const string PAPID = "PAPID";

        /// <summary>
        /// PATDAY.
        /// </summary>
        public const string PATDAY = "PATDAY";

        /// <summary>
        /// PAUPMJ.
        /// </summary>
        public const string PAUPMJ = "PAUPMJ";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAWAB.
        /// </summary>
        public const string PAWAB = "PAWAB";

        /// <summary>
        /// PAWCD.
        /// </summary>
        public const string PAWCD = "PAWCD";

        /// <summary>
        /// PAWMDT.
        /// </summary>
        public const string PAWMDT = "PAWMDT";

        /// <summary>
        /// PAWNUM.
        /// </summary>
        public const string PAWNUM = "PAWNUM";

        /// <summary>
        /// PAWRF.
        /// </summary>
        public const string PAWRF = "PAWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0740";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PAEURID", "PAEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("PAMCU", "PAMCU", JdeDataType.String, 24, true, true),
        new JdeField("PAACTIVITY", "PAACTIVITY", JdeDataType.String, 20, true, true),
        new JdeField("PAPLNTYP", "PAPLNTYP", JdeDataType.String, 2, true, true),
        new JdeField("PAPBEGDT", "PAPBEGDT", JdeDataType.Numeric),
        new JdeField("PAPENDDT", "PAPENDDT", JdeDataType.Numeric),
        new JdeField("PAPQA1", "PAPQA1", JdeDataType.Numeric),
        new JdeField("PAPQA2", "PAPQA2", JdeDataType.Numeric),
        new JdeField("PAPQA3", "PAPQA3", JdeDataType.Numeric),
        new JdeField("PAPQA4", "PAPQA4", JdeDataType.Numeric),
        new JdeField("PAPQA5", "PAPQA5", JdeDataType.Numeric),
        new JdeField("PAPQA6", "PAPQA6", JdeDataType.Numeric),
        new JdeField("PAPQA7", "PAPQA7", JdeDataType.Numeric),
        new JdeField("PAPQA8", "PAPQA8", JdeDataType.Numeric),
        new JdeField("PAPQA9", "PAPQA9", JdeDataType.Numeric),
        new JdeField("PAPQA10", "PAPQA10", JdeDataType.Numeric),
        new JdeField("PAPUOM1", "PAPUOM1", JdeDataType.String, 4),
        new JdeField("PAPUOM2", "PAPUOM2", JdeDataType.String, 4),
        new JdeField("PAPUOM3", "PAPUOM3", JdeDataType.String, 4),
        new JdeField("PAPUOM4", "PAPUOM4", JdeDataType.String, 4),
        new JdeField("PAPUOM5", "PAPUOM5", JdeDataType.String, 4),
        new JdeField("PAPUOM6", "PAPUOM6", JdeDataType.String, 4),
        new JdeField("PAPUOM7", "PAPUOM7", JdeDataType.String, 4),
        new JdeField("PAPUOM8", "PAPUOM8", JdeDataType.String, 4),
        new JdeField("PAPUOM9", "PAPUOM9", JdeDataType.String, 4),
        new JdeField("PAPUOM10", "PAPUOM10", JdeDataType.String, 4),
        new JdeField("PAPQC1", "PAPQC1", JdeDataType.String, 20),
        new JdeField("PAPQC2", "PAPQC2", JdeDataType.String, 20),
        new JdeField("PAPQC3", "PAPQC3", JdeDataType.String, 20),
        new JdeField("PAPQC4", "PAPQC4", JdeDataType.String, 20),
        new JdeField("PAPQC5", "PAPQC5", JdeDataType.String, 20),
        new JdeField("PAPQC6", "PAPQC6", JdeDataType.String, 20),
        new JdeField("PAPQC7", "PAPQC7", JdeDataType.String, 20),
        new JdeField("PAPQC8", "PAPQC8", JdeDataType.String, 20),
        new JdeField("PAPQC9", "PAPQC9", JdeDataType.String, 20),
        new JdeField("PAPQC10", "PAPQC10", JdeDataType.String, 20),
        new JdeField("PAURAB", "PAURAB", JdeDataType.Numeric),
        new JdeField("PAURAT", "PAURAT", JdeDataType.Numeric),
        new JdeField("PAURCD", "PAURCD", JdeDataType.String, 4),
        new JdeField("PAURDT", "PAURDT", JdeDataType.Numeric),
        new JdeField("PAURRF", "PAURRF", JdeDataType.String, 30),
        new JdeField("PAJOBN", "PAJOBN", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PATDAY", "PATDAY", JdeDataType.Numeric),
        new JdeField("PAUPMJ", "PAUPMJ", JdeDataType.Numeric),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAWAB", "PAWAB", JdeDataType.Numeric),
        new JdeField("PAWCD", "PAWCD", JdeDataType.String, 6),
        new JdeField("PAWMDT", "PAWMDT", JdeDataType.Numeric),
        new JdeField("PAWNUM", "PAWNUM", JdeDataType.Numeric),
        new JdeField("PAWRF", "PAWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0740_0", "Primary Key on PAEURID, PAMCU, PAACTIVITY, PAPLNTYP", new[] { "PAEURID", "PAMCU", "PAACTIVITY", "PAPLNTYP" }, isUnique: true, isPrimaryKey: true)
    };
}
