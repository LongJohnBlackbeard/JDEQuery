using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P511 - .
/// </summary>
public class F74P511 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AMP74AID.
        /// </summary>
        public const string AMP74AID = "AMP74AID";

        /// <summary>
        /// AMP74GRCG.
        /// </summary>
        public const string AMP74GRCG = "AMP74GRCG";

        /// <summary>
        /// AMP74ACCG.
        /// </summary>
        public const string AMP74ACCG = "AMP74ACCG";

        /// <summary>
        /// AMP74ACTY.
        /// </summary>
        public const string AMP74ACTY = "AMP74ACTY";

        /// <summary>
        /// AMUSER.
        /// </summary>
        public const string AMUSER = "AMUSER";

        /// <summary>
        /// AMPID.
        /// </summary>
        public const string AMPID = "AMPID";

        /// <summary>
        /// AMJOBN.
        /// </summary>
        public const string AMJOBN = "AMJOBN";

        /// <summary>
        /// AMUPMJ.
        /// </summary>
        public const string AMUPMJ = "AMUPMJ";

        /// <summary>
        /// AMUPMT.
        /// </summary>
        public const string AMUPMT = "AMUPMT";

        /// <summary>
        /// AMP74FUT01.
        /// </summary>
        public const string AMP74FUT01 = "AMP74FUT01";

        /// <summary>
        /// AMP74FUT02.
        /// </summary>
        public const string AMP74FUT02 = "AMP74FUT02";

        /// <summary>
        /// AMP74FUT03.
        /// </summary>
        public const string AMP74FUT03 = "AMP74FUT03";

        /// <summary>
        /// AMP74FLG04.
        /// </summary>
        public const string AMP74FLG04 = "AMP74FLG04";

        /// <summary>
        /// AMP74NUM05.
        /// </summary>
        public const string AMP74NUM05 = "AMP74NUM05";
    }

    /// <inheritdoc />
    public override string TableName => "F74P511";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AMP74AID", "AMP74AID", JdeDataType.String, 16, true, true),
        new JdeField("AMP74GRCG", "AMP74GRCG", JdeDataType.String, 20),
        new JdeField("AMP74ACCG", "AMP74ACCG", JdeDataType.String, 20),
        new JdeField("AMP74ACTY", "AMP74ACTY", JdeDataType.Numeric),
        new JdeField("AMUSER", "AMUSER", JdeDataType.String, 20),
        new JdeField("AMPID", "AMPID", JdeDataType.String, 20),
        new JdeField("AMJOBN", "AMJOBN", JdeDataType.String, 20),
        new JdeField("AMUPMJ", "AMUPMJ", JdeDataType.Numeric),
        new JdeField("AMUPMT", "AMUPMT", JdeDataType.Numeric),
        new JdeField("AMP74FUT01", "AMP74FUT01", JdeDataType.Numeric),
        new JdeField("AMP74FUT02", "AMP74FUT02", JdeDataType.String, 60),
        new JdeField("AMP74FUT03", "AMP74FUT03", JdeDataType.String, 2),
        new JdeField("AMP74FLG04", "AMP74FLG04", JdeDataType.String, 2),
        new JdeField("AMP74NUM05", "AMP74NUM05", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P511_0", "Primary Key on AMP74AID", new[] { "AMP74AID" }, isUnique: true, isPrimaryKey: true)
    };
}
