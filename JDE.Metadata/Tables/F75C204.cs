using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C204 - .
/// </summary>
public class F75C204 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AHCO.
        /// </summary>
        public const string AHCO = "AHCO";

        /// <summary>
        /// AHNUMB.
        /// </summary>
        public const string AHNUMB = "AHNUMB";

        /// <summary>
        /// AHC75ACCYR.
        /// </summary>
        public const string AHC75ACCYR = "AHC75ACCYR";

        /// <summary>
        /// AHC75ACCPD.
        /// </summary>
        public const string AHC75ACCPD = "AHC75ACCPD";

        /// <summary>
        /// AHEQST.
        /// </summary>
        public const string AHEQST = "AHEQST";

        /// <summary>
        /// AHARCQ.
        /// </summary>
        public const string AHARCQ = "AHARCQ";

        /// <summary>
        /// AHFINC.
        /// </summary>
        public const string AHFINC = "AHFINC";

        /// <summary>
        /// AHADM.
        /// </summary>
        public const string AHADM = "AHADM";

        /// <summary>
        /// AHADLM.
        /// </summary>
        public const string AHADLM = "AHADLM";

        /// <summary>
        /// AHTKER.
        /// </summary>
        public const string AHTKER = "AHTKER";

        /// <summary>
        /// AHFUTMATH1.
        /// </summary>
        public const string AHFUTMATH1 = "AHFUTMATH1";

        /// <summary>
        /// AHFUTMATH2.
        /// </summary>
        public const string AHFUTMATH2 = "AHFUTMATH2";

        /// <summary>
        /// AHFUTSTR1.
        /// </summary>
        public const string AHFUTSTR1 = "AHFUTSTR1";

        /// <summary>
        /// AHFUTSTR2.
        /// </summary>
        public const string AHFUTSTR2 = "AHFUTSTR2";

        /// <summary>
        /// AHFUTDATE1.
        /// </summary>
        public const string AHFUTDATE1 = "AHFUTDATE1";

        /// <summary>
        /// AHFUTUO1.
        /// </summary>
        public const string AHFUTUO1 = "AHFUTUO1";

        /// <summary>
        /// AHUSER.
        /// </summary>
        public const string AHUSER = "AHUSER";

        /// <summary>
        /// AHPID.
        /// </summary>
        public const string AHPID = "AHPID";

        /// <summary>
        /// AHJOBN.
        /// </summary>
        public const string AHJOBN = "AHJOBN";

        /// <summary>
        /// AHUPMJ.
        /// </summary>
        public const string AHUPMJ = "AHUPMJ";

        /// <summary>
        /// AHUPMT.
        /// </summary>
        public const string AHUPMT = "AHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C204";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AHCO", "AHCO", JdeDataType.String, 10),
        new JdeField("AHNUMB", "AHNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("AHC75ACCYR", "AHC75ACCYR", JdeDataType.Numeric, null, true, true),
        new JdeField("AHC75ACCPD", "AHC75ACCPD", JdeDataType.Numeric, null, true, true),
        new JdeField("AHEQST", "AHEQST", JdeDataType.String, 4),
        new JdeField("AHARCQ", "AHARCQ", JdeDataType.Numeric),
        new JdeField("AHFINC", "AHFINC", JdeDataType.String, 2),
        new JdeField("AHADM", "AHADM", JdeDataType.String, 4),
        new JdeField("AHADLM", "AHADLM", JdeDataType.Numeric),
        new JdeField("AHTKER", "AHTKER", JdeDataType.Numeric),
        new JdeField("AHFUTMATH1", "AHFUTMATH1", JdeDataType.Numeric),
        new JdeField("AHFUTMATH2", "AHFUTMATH2", JdeDataType.Numeric),
        new JdeField("AHFUTSTR1", "AHFUTSTR1", JdeDataType.String, 100),
        new JdeField("AHFUTSTR2", "AHFUTSTR2", JdeDataType.String, 100),
        new JdeField("AHFUTDATE1", "AHFUTDATE1", JdeDataType.Numeric),
        new JdeField("AHFUTUO1", "AHFUTUO1", JdeDataType.String, 2),
        new JdeField("AHUSER", "AHUSER", JdeDataType.String, 20),
        new JdeField("AHPID", "AHPID", JdeDataType.String, 20),
        new JdeField("AHJOBN", "AHJOBN", JdeDataType.String, 20),
        new JdeField("AHUPMJ", "AHUPMJ", JdeDataType.Numeric),
        new JdeField("AHUPMT", "AHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C204_0", "Primary Key on AHNUMB, AHC75ACCYR, AHC75ACCPD", new[] { "AHNUMB", "AHC75ACCYR", "AHC75ACCPD" }, isUnique: true, isPrimaryKey: true)
    };
}
