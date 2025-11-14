using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I390 - .
/// </summary>
public class F75I390 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ERAN8.
        /// </summary>
        public const string ERAN8 = "ERAN8";

        /// <summary>
        /// ERYCHN.
        /// </summary>
        public const string ERYCHN = "ERYCHN";

        /// <summary>
        /// ERITM.
        /// </summary>
        public const string ERITM = "ERITM";

        /// <summary>
        /// ERLITM.
        /// </summary>
        public const string ERLITM = "ERLITM";

        /// <summary>
        /// ERUOM.
        /// </summary>
        public const string ERUOM = "ERUOM";

        /// <summary>
        /// ERYRM.
        /// </summary>
        public const string ERYRM = "ERYRM";

        /// <summary>
        /// ERMT.
        /// </summary>
        public const string ERMT = "ERMT";

        /// <summary>
        /// ERTRQT.
        /// </summary>
        public const string ERTRQT = "ERTRQT";

        /// <summary>
        /// ERTDAY.
        /// </summary>
        public const string ERTDAY = "ERTDAY";

        /// <summary>
        /// ERUPMJ.
        /// </summary>
        public const string ERUPMJ = "ERUPMJ";

        /// <summary>
        /// ERJOBN.
        /// </summary>
        public const string ERJOBN = "ERJOBN";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERYEXU.
        /// </summary>
        public const string ERYEXU = "ERYEXU";

        /// <summary>
        /// ERI75SEC.
        /// </summary>
        public const string ERI75SEC = "ERI75SEC";
    }

    /// <inheritdoc />
    public override string TableName => "F75I390";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ERAN8", "ERAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ERYCHN", "ERYCHN", JdeDataType.String, 40, true, true),
        new JdeField("ERITM", "ERITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ERLITM", "ERLITM", JdeDataType.String, 50),
        new JdeField("ERUOM", "ERUOM", JdeDataType.String, 4),
        new JdeField("ERYRM", "ERYRM", JdeDataType.Numeric, null, true, true),
        new JdeField("ERMT", "ERMT", JdeDataType.Numeric, null, true, true),
        new JdeField("ERTRQT", "ERTRQT", JdeDataType.Numeric),
        new JdeField("ERTDAY", "ERTDAY", JdeDataType.Numeric),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric),
        new JdeField("ERJOBN", "ERJOBN", JdeDataType.String, 20),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERYEXU", "ERYEXU", JdeDataType.Numeric),
        new JdeField("ERI75SEC", "ERI75SEC", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I390_0", "Primary Key on ERAN8, ERYCHN, ERITM, ERYRM, ERMT, ERI75SEC", new[] { "ERAN8", "ERYCHN", "ERITM", "ERYRM", "ERMT", "ERI75SEC" }, isUnique: true, isPrimaryKey: true)
    };
}
