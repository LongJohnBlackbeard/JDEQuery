using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW33 - .
/// </summary>
public class FCW33 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHC9PLN.
        /// </summary>
        public const string PHC9PLN = "PHC9PLN";

        /// <summary>
        /// PHAN8.
        /// </summary>
        public const string PHAN8 = "PHAN8";

        /// <summary>
        /// PHCPGP.
        /// </summary>
        public const string PHCPGP = "PHCPGP";

        /// <summary>
        /// PHCGP1.
        /// </summary>
        public const string PHCGP1 = "PHCGP1";

        /// <summary>
        /// PHCGP2.
        /// </summary>
        public const string PHCGP2 = "PHCGP2";

        /// <summary>
        /// PHCGP3.
        /// </summary>
        public const string PHCGP3 = "PHCGP3";

        /// <summary>
        /// PHCGP4.
        /// </summary>
        public const string PHCGP4 = "PHCGP4";

        /// <summary>
        /// PHICID.
        /// </summary>
        public const string PHICID = "PHICID";

        /// <summary>
        /// PHCRCD.
        /// </summary>
        public const string PHCRCD = "PHCRCD";

        /// <summary>
        /// PHEFTJ.
        /// </summary>
        public const string PHEFTJ = "PHEFTJ";

        /// <summary>
        /// PHEXDJ.
        /// </summary>
        public const string PHEXDJ = "PHEXDJ";

        /// <summary>
        /// PHPLEV.
        /// </summary>
        public const string PHPLEV = "PHPLEV";

        /// <summary>
        /// PHMCU.
        /// </summary>
        public const string PHMCU = "PHMCU";

        /// <summary>
        /// PHLOCN.
        /// </summary>
        public const string PHLOCN = "PHLOCN";

        /// <summary>
        /// PHLOTN.
        /// </summary>
        public const string PHLOTN = "PHLOTN";

        /// <summary>
        /// PHC9CTC1.
        /// </summary>
        public const string PHC9CTC1 = "PHC9CTC1";

        /// <summary>
        /// PHC9CTC2.
        /// </summary>
        public const string PHC9CTC2 = "PHC9CTC2";

        /// <summary>
        /// PHC9CTC3.
        /// </summary>
        public const string PHC9CTC3 = "PHC9CTC3";

        /// <summary>
        /// PHC9CTC4.
        /// </summary>
        public const string PHC9CTC4 = "PHC9CTC4";

        /// <summary>
        /// PHC9CTC5.
        /// </summary>
        public const string PHC9CTC5 = "PHC9CTC5";

        /// <summary>
        /// PHC9COLL.
        /// </summary>
        public const string PHC9COLL = "PHC9COLL";

        /// <summary>
        /// PHC9SEAC.
        /// </summary>
        public const string PHC9SEAC = "PHC9SEAC";

        /// <summary>
        /// PHC9SEAY.
        /// </summary>
        public const string PHC9SEAY = "PHC9SEAY";

        /// <summary>
        /// PHURCD.
        /// </summary>
        public const string PHURCD = "PHURCD";

        /// <summary>
        /// PHURDT.
        /// </summary>
        public const string PHURDT = "PHURDT";

        /// <summary>
        /// PHURAT.
        /// </summary>
        public const string PHURAT = "PHURAT";

        /// <summary>
        /// PHURAB.
        /// </summary>
        public const string PHURAB = "PHURAB";

        /// <summary>
        /// PHURRF.
        /// </summary>
        public const string PHURRF = "PHURRF";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHTDAY.
        /// </summary>
        public const string PHTDAY = "PHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW33";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHC9PLN", "PHC9PLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PHAN8", "PHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PHCPGP", "PHCPGP", JdeDataType.String, 16, true, true),
        new JdeField("PHCGP1", "PHCGP1", JdeDataType.String, 6, true, true),
        new JdeField("PHCGP2", "PHCGP2", JdeDataType.String, 6, true, true),
        new JdeField("PHCGP3", "PHCGP3", JdeDataType.String, 6, true, true),
        new JdeField("PHCGP4", "PHCGP4", JdeDataType.String, 6, true, true),
        new JdeField("PHICID", "PHICID", JdeDataType.Numeric),
        new JdeField("PHCRCD", "PHCRCD", JdeDataType.String, 6, true, true),
        new JdeField("PHEFTJ", "PHEFTJ", JdeDataType.Numeric),
        new JdeField("PHEXDJ", "PHEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PHPLEV", "PHPLEV", JdeDataType.String, 2, true, true),
        new JdeField("PHMCU", "PHMCU", JdeDataType.String, 24),
        new JdeField("PHLOCN", "PHLOCN", JdeDataType.String, 40),
        new JdeField("PHLOTN", "PHLOTN", JdeDataType.String, 60),
        new JdeField("PHC9CTC1", "PHC9CTC1", JdeDataType.String, 20),
        new JdeField("PHC9CTC2", "PHC9CTC2", JdeDataType.String, 20),
        new JdeField("PHC9CTC3", "PHC9CTC3", JdeDataType.String, 20),
        new JdeField("PHC9CTC4", "PHC9CTC4", JdeDataType.String, 20),
        new JdeField("PHC9CTC5", "PHC9CTC5", JdeDataType.String, 20),
        new JdeField("PHC9COLL", "PHC9COLL", JdeDataType.String, 20),
        new JdeField("PHC9SEAC", "PHC9SEAC", JdeDataType.String, 4),
        new JdeField("PHC9SEAY", "PHC9SEAY", JdeDataType.String, 8),
        new JdeField("PHURCD", "PHURCD", JdeDataType.String, 4),
        new JdeField("PHURDT", "PHURDT", JdeDataType.Numeric),
        new JdeField("PHURAT", "PHURAT", JdeDataType.Numeric),
        new JdeField("PHURAB", "PHURAB", JdeDataType.Numeric),
        new JdeField("PHURRF", "PHURRF", JdeDataType.String, 30),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHTDAY", "PHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW33_0", "Primary Key on PHC9PLN, PHAN8, PHCPGP, PHCGP1, PHCGP2, PHCGP3, PHCGP4, PHCRCD, PHEXDJ, PHPLEV", new[] { "PHC9PLN", "PHAN8", "PHCPGP", "PHCGP1", "PHCGP2", "PHCGP3", "PHCGP4", "PHCRCD", "PHEXDJ", "PHPLEV" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW33_2", "Unique Index on PHAN8, PHCPGP, PHCGP1, PHCGP2, PHCGP3, PHCGP4, PHCRCD, PHEXDJ, PHPLEV", new[] { "PHAN8", "PHCPGP", "PHCGP1", "PHCGP2", "PHCGP3", "PHCGP4", "PHCRCD", "PHEXDJ", "PHPLEV" }, isUnique: true)
    };
}
