using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C010 - .
/// </summary>
public class F75C010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// URC75RECN.
        /// </summary>
        public const string URC75RECN = "URC75RECN";

        /// <summary>
        /// URC75RDSC.
        /// </summary>
        public const string URC75RDSC = "URC75RDSC";

        /// <summary>
        /// URC75CAT.
        /// </summary>
        public const string URC75CAT = "URC75CAT";

        /// <summary>
        /// URADTY.
        /// </summary>
        public const string URADTY = "URADTY";

        /// <summary>
        /// URC75OSINF.
        /// </summary>
        public const string URC75OSINF = "URC75OSINF";

        /// <summary>
        /// URC75CORS.
        /// </summary>
        public const string URC75CORS = "URC75CORS";

        /// <summary>
        /// URFUT1.
        /// </summary>
        public const string URFUT1 = "URFUT1";

        /// <summary>
        /// URFUT3.
        /// </summary>
        public const string URFUT3 = "URFUT3";

        /// <summary>
        /// URFUT4.
        /// </summary>
        public const string URFUT4 = "URFUT4";

        /// <summary>
        /// URFUTDATE1.
        /// </summary>
        public const string URFUTDATE1 = "URFUTDATE1";

        /// <summary>
        /// URFUTANON1.
        /// </summary>
        public const string URFUTANON1 = "URFUTANON1";

        /// <summary>
        /// URUSER.
        /// </summary>
        public const string URUSER = "URUSER";

        /// <summary>
        /// URPID.
        /// </summary>
        public const string URPID = "URPID";

        /// <summary>
        /// URJOBN.
        /// </summary>
        public const string URJOBN = "URJOBN";

        /// <summary>
        /// URUPMJ.
        /// </summary>
        public const string URUPMJ = "URUPMJ";

        /// <summary>
        /// URUPMT.
        /// </summary>
        public const string URUPMT = "URUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("URC75RECN", "URC75RECN", JdeDataType.String, 120, true, true),
        new JdeField("URC75RDSC", "URC75RDSC", JdeDataType.String, 2000),
        new JdeField("URC75CAT", "URC75CAT", JdeDataType.String, 4),
        new JdeField("URADTY", "URADTY", JdeDataType.String, 20),
        new JdeField("URC75OSINF", "URC75OSINF", JdeDataType.String, 2),
        new JdeField("URC75CORS", "URC75CORS", JdeDataType.String, 400),
        new JdeField("URFUT1", "URFUT1", JdeDataType.Numeric),
        new JdeField("URFUT3", "URFUT3", JdeDataType.String, 60),
        new JdeField("URFUT4", "URFUT4", JdeDataType.String, 50),
        new JdeField("URFUTDATE1", "URFUTDATE1", JdeDataType.Numeric),
        new JdeField("URFUTANON1", "URFUTANON1", JdeDataType.String, 2),
        new JdeField("URUSER", "URUSER", JdeDataType.String, 20),
        new JdeField("URPID", "URPID", JdeDataType.String, 20),
        new JdeField("URJOBN", "URJOBN", JdeDataType.String, 20),
        new JdeField("URUPMJ", "URUPMJ", JdeDataType.Numeric),
        new JdeField("URUPMT", "URUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C010_0", "Primary Key on URC75RECN", new[] { "URC75RECN" }, isUnique: true, isPrimaryKey: true)
    };
}
