using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P512 - .
/// </summary>
public class F74P512 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WTUKID.
        /// </summary>
        public const string WTUKID = "WTUKID";

        /// <summary>
        /// WTP74AID.
        /// </summary>
        public const string WTP74AID = "WTP74AID";

        /// <summary>
        /// WTANI.
        /// </summary>
        public const string WTANI = "WTANI";

        /// <summary>
        /// WTUSER.
        /// </summary>
        public const string WTUSER = "WTUSER";

        /// <summary>
        /// WTPID.
        /// </summary>
        public const string WTPID = "WTPID";

        /// <summary>
        /// WTJOBN.
        /// </summary>
        public const string WTJOBN = "WTJOBN";

        /// <summary>
        /// WTUPMJ.
        /// </summary>
        public const string WTUPMJ = "WTUPMJ";

        /// <summary>
        /// WTUPMT.
        /// </summary>
        public const string WTUPMT = "WTUPMT";

        /// <summary>
        /// WTP74FUT01.
        /// </summary>
        public const string WTP74FUT01 = "WTP74FUT01";

        /// <summary>
        /// WTP74FUT02.
        /// </summary>
        public const string WTP74FUT02 = "WTP74FUT02";

        /// <summary>
        /// WTP74FUT03.
        /// </summary>
        public const string WTP74FUT03 = "WTP74FUT03";

        /// <summary>
        /// WTP74FLG04.
        /// </summary>
        public const string WTP74FLG04 = "WTP74FLG04";

        /// <summary>
        /// WTP74NUM05.
        /// </summary>
        public const string WTP74NUM05 = "WTP74NUM05";
    }

    /// <inheritdoc />
    public override string TableName => "F74P512";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WTUKID", "WTUKID", JdeDataType.Numeric),
        new JdeField("WTP74AID", "WTP74AID", JdeDataType.String, 16, true, true),
        new JdeField("WTANI", "WTANI", JdeDataType.String, 58),
        new JdeField("WTUSER", "WTUSER", JdeDataType.String, 20),
        new JdeField("WTPID", "WTPID", JdeDataType.String, 20),
        new JdeField("WTJOBN", "WTJOBN", JdeDataType.String, 20),
        new JdeField("WTUPMJ", "WTUPMJ", JdeDataType.Numeric),
        new JdeField("WTUPMT", "WTUPMT", JdeDataType.Numeric),
        new JdeField("WTP74FUT01", "WTP74FUT01", JdeDataType.Numeric),
        new JdeField("WTP74FUT02", "WTP74FUT02", JdeDataType.String, 60),
        new JdeField("WTP74FUT03", "WTP74FUT03", JdeDataType.String, 2),
        new JdeField("WTP74FLG04", "WTP74FLG04", JdeDataType.String, 2),
        new JdeField("WTP74NUM05", "WTP74NUM05", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P512_0", "Primary Key on WTP74AID", new[] { "WTP74AID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74P512_2", "Index on WTP74AID, WTUKID", new[] { "WTP74AID", "WTUKID" })
    };
}
