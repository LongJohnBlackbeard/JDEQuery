using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08122W - .
/// </summary>
public class F08122W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TWRPYR.
        /// </summary>
        public const string TWRPYR = "TWRPYR";

        /// <summary>
        /// TWTAXX.
        /// </summary>
        public const string TWTAXX = "TWTAXX";

        /// <summary>
        /// TWAN8.
        /// </summary>
        public const string TWAN8 = "TWAN8";

        /// <summary>
        /// TWDI01.
        /// </summary>
        public const string TWDI01 = "TWDI01";

        /// <summary>
        /// TWDI02.
        /// </summary>
        public const string TWDI02 = "TWDI02";

        /// <summary>
        /// TWDI03.
        /// </summary>
        public const string TWDI03 = "TWDI03";

        /// <summary>
        /// TWDI04.
        /// </summary>
        public const string TWDI04 = "TWDI04";

        /// <summary>
        /// TWDI05.
        /// </summary>
        public const string TWDI05 = "TWDI05";

        /// <summary>
        /// TWDI06.
        /// </summary>
        public const string TWDI06 = "TWDI06";

        /// <summary>
        /// TWDI07.
        /// </summary>
        public const string TWDI07 = "TWDI07";

        /// <summary>
        /// TWDI08.
        /// </summary>
        public const string TWDI08 = "TWDI08";

        /// <summary>
        /// TWDI09.
        /// </summary>
        public const string TWDI09 = "TWDI09";

        /// <summary>
        /// TWDI10.
        /// </summary>
        public const string TWDI10 = "TWDI10";

        /// <summary>
        /// TWDI11.
        /// </summary>
        public const string TWDI11 = "TWDI11";

        /// <summary>
        /// TWDI12.
        /// </summary>
        public const string TWDI12 = "TWDI12";

        /// <summary>
        /// TWSPASUSF1.
        /// </summary>
        public const string TWSPASUSF1 = "TWSPASUSF1";

        /// <summary>
        /// TWSPASUSF2.
        /// </summary>
        public const string TWSPASUSF2 = "TWSPASUSF2";

        /// <summary>
        /// TWSPASUSF3.
        /// </summary>
        public const string TWSPASUSF3 = "TWSPASUSF3";

        /// <summary>
        /// TWSPASUSF4.
        /// </summary>
        public const string TWSPASUSF4 = "TWSPASUSF4";

        /// <summary>
        /// TWSPANUSF1.
        /// </summary>
        public const string TWSPANUSF1 = "TWSPANUSF1";

        /// <summary>
        /// TWSPANUSF2.
        /// </summary>
        public const string TWSPANUSF2 = "TWSPANUSF2";

        /// <summary>
        /// TWSPANUSF3.
        /// </summary>
        public const string TWSPANUSF3 = "TWSPANUSF3";

        /// <summary>
        /// TWSPANUSF4.
        /// </summary>
        public const string TWSPANUSF4 = "TWSPANUSF4";

        /// <summary>
        /// TWSPACUSD3.
        /// </summary>
        public const string TWSPACUSD3 = "TWSPACUSD3";

        /// <summary>
        /// TWSPACUSD4.
        /// </summary>
        public const string TWSPACUSD4 = "TWSPACUSD4";

        /// <summary>
        /// TWUSER.
        /// </summary>
        public const string TWUSER = "TWUSER";

        /// <summary>
        /// TWUPDJ.
        /// </summary>
        public const string TWUPDJ = "TWUPDJ";

        /// <summary>
        /// TWPID.
        /// </summary>
        public const string TWPID = "TWPID";

        /// <summary>
        /// TWUPMT.
        /// </summary>
        public const string TWUPMT = "TWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08122W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TWRPYR", "TWRPYR", JdeDataType.Numeric, null, true, true),
        new JdeField("TWTAXX", "TWTAXX", JdeDataType.String, 40, true, true),
        new JdeField("TWAN8", "TWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TWDI01", "TWDI01", JdeDataType.String, 2),
        new JdeField("TWDI02", "TWDI02", JdeDataType.String, 2),
        new JdeField("TWDI03", "TWDI03", JdeDataType.String, 2),
        new JdeField("TWDI04", "TWDI04", JdeDataType.String, 2),
        new JdeField("TWDI05", "TWDI05", JdeDataType.String, 2),
        new JdeField("TWDI06", "TWDI06", JdeDataType.String, 2),
        new JdeField("TWDI07", "TWDI07", JdeDataType.String, 2),
        new JdeField("TWDI08", "TWDI08", JdeDataType.String, 2),
        new JdeField("TWDI09", "TWDI09", JdeDataType.String, 2),
        new JdeField("TWDI10", "TWDI10", JdeDataType.String, 2),
        new JdeField("TWDI11", "TWDI11", JdeDataType.String, 2),
        new JdeField("TWDI12", "TWDI12", JdeDataType.String, 2),
        new JdeField("TWSPASUSF1", "TWSPASUSF1", JdeDataType.String, 60),
        new JdeField("TWSPASUSF2", "TWSPASUSF2", JdeDataType.String, 60),
        new JdeField("TWSPASUSF3", "TWSPASUSF3", JdeDataType.String, 60),
        new JdeField("TWSPASUSF4", "TWSPASUSF4", JdeDataType.String, 60),
        new JdeField("TWSPANUSF1", "TWSPANUSF1", JdeDataType.Numeric),
        new JdeField("TWSPANUSF2", "TWSPANUSF2", JdeDataType.Numeric),
        new JdeField("TWSPANUSF3", "TWSPANUSF3", JdeDataType.Numeric),
        new JdeField("TWSPANUSF4", "TWSPANUSF4", JdeDataType.Numeric),
        new JdeField("TWSPACUSD3", "TWSPACUSD3", JdeDataType.String, 2),
        new JdeField("TWSPACUSD4", "TWSPACUSD4", JdeDataType.String, 2),
        new JdeField("TWUSER", "TWUSER", JdeDataType.String, 20),
        new JdeField("TWUPDJ", "TWUPDJ", JdeDataType.Numeric),
        new JdeField("TWPID", "TWPID", JdeDataType.String, 20),
        new JdeField("TWUPMT", "TWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08122W_0", "Primary Key on TWRPYR, TWTAXX, TWAN8", new[] { "TWRPYR", "TWTAXX", "TWAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
