using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4622 - .
/// </summary>
public class F4622 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ULMCU.
        /// </summary>
        public const string ULMCU = "ULMCU";

        /// <summary>
        /// ULLBLSN.
        /// </summary>
        public const string ULLBLSN = "ULLBLSN";

        /// <summary>
        /// ULLDTAI.
        /// </summary>
        public const string ULLDTAI = "ULLDTAI";

        /// <summary>
        /// ULSHPN.
        /// </summary>
        public const string ULSHPN = "ULSHPN";

        /// <summary>
        /// ULEQTY.
        /// </summary>
        public const string ULEQTY = "ULEQTY";

        /// <summary>
        /// ULULBLRC.
        /// </summary>
        public const string ULULBLRC = "ULULBLRC";

        /// <summary>
        /// ULCTNI.
        /// </summary>
        public const string ULCTNI = "ULCTNI";

        /// <summary>
        /// ULCEQT.
        /// </summary>
        public const string ULCEQT = "ULCEQT";

        /// <summary>
        /// ULFUT1.
        /// </summary>
        public const string ULFUT1 = "ULFUT1";

        /// <summary>
        /// ULFUT2.
        /// </summary>
        public const string ULFUT2 = "ULFUT2";

        /// <summary>
        /// ULFUT3.
        /// </summary>
        public const string ULFUT3 = "ULFUT3";

        /// <summary>
        /// ULFUT4.
        /// </summary>
        public const string ULFUT4 = "ULFUT4";

        /// <summary>
        /// ULFUT5.
        /// </summary>
        public const string ULFUT5 = "ULFUT5";

        /// <summary>
        /// ULUSER.
        /// </summary>
        public const string ULUSER = "ULUSER";

        /// <summary>
        /// ULPID.
        /// </summary>
        public const string ULPID = "ULPID";

        /// <summary>
        /// ULJOBN.
        /// </summary>
        public const string ULJOBN = "ULJOBN";

        /// <summary>
        /// ULUPMJ.
        /// </summary>
        public const string ULUPMJ = "ULUPMJ";

        /// <summary>
        /// ULTDAY.
        /// </summary>
        public const string ULTDAY = "ULTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4622";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ULMCU", "ULMCU", JdeDataType.String, 24, true, true),
        new JdeField("ULLBLSN", "ULLBLSN", JdeDataType.String, 36, true, true),
        new JdeField("ULLDTAI", "ULLDTAI", JdeDataType.String, 6),
        new JdeField("ULSHPN", "ULSHPN", JdeDataType.Numeric),
        new JdeField("ULEQTY", "ULEQTY", JdeDataType.String, 10),
        new JdeField("ULULBLRC", "ULULBLRC", JdeDataType.String, 6),
        new JdeField("ULCTNI", "ULCTNI", JdeDataType.Numeric),
        new JdeField("ULCEQT", "ULCEQT", JdeDataType.String, 50),
        new JdeField("ULFUT1", "ULFUT1", JdeDataType.Numeric),
        new JdeField("ULFUT2", "ULFUT2", JdeDataType.Numeric),
        new JdeField("ULFUT3", "ULFUT3", JdeDataType.String, 60),
        new JdeField("ULFUT4", "ULFUT4", JdeDataType.String, 50),
        new JdeField("ULFUT5", "ULFUT5", JdeDataType.String, 50),
        new JdeField("ULUSER", "ULUSER", JdeDataType.String, 20),
        new JdeField("ULPID", "ULPID", JdeDataType.String, 20),
        new JdeField("ULJOBN", "ULJOBN", JdeDataType.String, 20),
        new JdeField("ULUPMJ", "ULUPMJ", JdeDataType.Numeric),
        new JdeField("ULTDAY", "ULTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4622_0", "Primary Key on ULMCU, ULLBLSN", new[] { "ULMCU", "ULLBLSN" }, isUnique: true, isPrimaryKey: true)
    };
}
