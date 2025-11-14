using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01RS13W - .
/// </summary>
public class F01RS13W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TASESSID.
        /// </summary>
        public const string TASESSID = "TASESSID";

        /// <summary>
        /// TARLTYPE.
        /// </summary>
        public const string TARLTYPE = "TARLTYPE";

        /// <summary>
        /// TARSTVC.
        /// </summary>
        public const string TARSTVC = "TARSTVC";

        /// <summary>
        /// TAROLE.
        /// </summary>
        public const string TAROLE = "TAROLE";

        /// <summary>
        /// TALNGTASK1.
        /// </summary>
        public const string TALNGTASK1 = "TALNGTASK1";

        /// <summary>
        /// TALNGTASK2.
        /// </summary>
        public const string TALNGTASK2 = "TALNGTASK2";

        /// <summary>
        /// TALNGTASK3.
        /// </summary>
        public const string TALNGTASK3 = "TALNGTASK3";

        /// <summary>
        /// TALNGTASK4.
        /// </summary>
        public const string TALNGTASK4 = "TALNGTASK4";

        /// <summary>
        /// TALNGTASK5.
        /// </summary>
        public const string TALNGTASK5 = "TALNGTASK5";

        /// <summary>
        /// TATASKTYPE.
        /// </summary>
        public const string TATASKTYPE = "TATASKTYPE";

        /// <summary>
        /// TAOBNM.
        /// </summary>
        public const string TAOBNM = "TAOBNM";

        /// <summary>
        /// TAVER.
        /// </summary>
        public const string TAVER = "TAVER";

        /// <summary>
        /// TAFMNM.
        /// </summary>
        public const string TAFMNM = "TAFMNM";

        /// <summary>
        /// TALVDT.
        /// </summary>
        public const string TALVDT = "TALVDT";
    }

    /// <inheritdoc />
    public override string TableName => "F01RS13W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TASESSID", "TASESSID", JdeDataType.String, 64, true, true),
        new JdeField("TARLTYPE", "TARLTYPE", JdeDataType.String, 10, true, true),
        new JdeField("TARSTVC", "TARSTVC", JdeDataType.Numeric, null, true, true),
        new JdeField("TAROLE", "TAROLE", JdeDataType.String, 72, true, true),
        new JdeField("TALNGTASK1", "TALNGTASK1", JdeDataType.String, 160),
        new JdeField("TALNGTASK2", "TALNGTASK2", JdeDataType.String, 160),
        new JdeField("TALNGTASK3", "TALNGTASK3", JdeDataType.String, 160),
        new JdeField("TALNGTASK4", "TALNGTASK4", JdeDataType.String, 160),
        new JdeField("TALNGTASK5", "TALNGTASK5", JdeDataType.String, 160),
        new JdeField("TATASKTYPE", "TATASKTYPE", JdeDataType.String, 4),
        new JdeField("TAOBNM", "TAOBNM", JdeDataType.String, 20),
        new JdeField("TAVER", "TAVER", JdeDataType.String, 20),
        new JdeField("TAFMNM", "TAFMNM", JdeDataType.String, 20),
        new JdeField("TALVDT", "TALVDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01RS13W_0", "Primary Key on TASESSID, TARLTYPE, TARSTVC, TAROLE", new[] { "TASESSID", "TARLTYPE", "TARSTVC", "TAROLE" }, isUnique: true, isPrimaryKey: true)
    };
}
