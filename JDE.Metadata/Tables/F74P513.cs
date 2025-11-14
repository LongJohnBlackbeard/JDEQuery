using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P513 - .
/// </summary>
public class F74P513 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISUKID.
        /// </summary>
        public const string ISUKID = "ISUKID";

        /// <summary>
        /// ISCO.
        /// </summary>
        public const string ISCO = "ISCO";

        /// <summary>
        /// ISDCT.
        /// </summary>
        public const string ISDCT = "ISDCT";

        /// <summary>
        /// ISDCTO.
        /// </summary>
        public const string ISDCTO = "ISDCTO";

        /// <summary>
        /// ISP74ISEC.
        /// </summary>
        public const string ISP74ISEC = "ISP74ISEC";

        /// <summary>
        /// ISP74FUT01.
        /// </summary>
        public const string ISP74FUT01 = "ISP74FUT01";

        /// <summary>
        /// ISP74FUT02.
        /// </summary>
        public const string ISP74FUT02 = "ISP74FUT02";

        /// <summary>
        /// ISP74FUT03.
        /// </summary>
        public const string ISP74FUT03 = "ISP74FUT03";

        /// <summary>
        /// ISP74FLG04.
        /// </summary>
        public const string ISP74FLG04 = "ISP74FLG04";

        /// <summary>
        /// ISP74NUM05.
        /// </summary>
        public const string ISP74NUM05 = "ISP74NUM05";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISPID.
        /// </summary>
        public const string ISPID = "ISPID";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// ISUPMT.
        /// </summary>
        public const string ISUPMT = "ISUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74P513";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISUKID", "ISUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ISCO", "ISCO", JdeDataType.String, 10),
        new JdeField("ISDCT", "ISDCT", JdeDataType.String, 4),
        new JdeField("ISDCTO", "ISDCTO", JdeDataType.String, 4),
        new JdeField("ISP74ISEC", "ISP74ISEC", JdeDataType.String, 4),
        new JdeField("ISP74FUT01", "ISP74FUT01", JdeDataType.Numeric),
        new JdeField("ISP74FUT02", "ISP74FUT02", JdeDataType.String, 60),
        new JdeField("ISP74FUT03", "ISP74FUT03", JdeDataType.String, 2),
        new JdeField("ISP74FLG04", "ISP74FLG04", JdeDataType.String, 2),
        new JdeField("ISP74NUM05", "ISP74NUM05", JdeDataType.Numeric),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISPID", "ISPID", JdeDataType.String, 20),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("ISUPMT", "ISUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P513_0", "Primary Key on ISUKID", new[] { "ISUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
