using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U25BT - .
/// </summary>
public class F74U25BT : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PKFETP.
        /// </summary>
        public const string PKFETP = "PKFETP";

        /// <summary>
        /// PKDOCO.
        /// </summary>
        public const string PKDOCO = "PKDOCO";

        /// <summary>
        /// PKAN8.
        /// </summary>
        public const string PKAN8 = "PKAN8";

        /// <summary>
        /// PKMCU.
        /// </summary>
        public const string PKMCU = "PKMCU";

        /// <summary>
        /// PKGLC.
        /// </summary>
        public const string PKGLC = "PKGLC";

        /// <summary>
        /// PKAGSN.
        /// </summary>
        public const string PKAGSN = "PKAGSN";

        /// <summary>
        /// PKLNID.
        /// </summary>
        public const string PKLNID = "PKLNID";

        /// <summary>
        /// PK74UBKCD.
        /// </summary>
        public const string PK74UBKCD = "PK74UBKCD";

        /// <summary>
        /// PK74UCRCD.
        /// </summary>
        public const string PK74UCRCD = "PK74UCRCD";

        /// <summary>
        /// PKCRRM.
        /// </summary>
        public const string PKCRRM = "PKCRRM";

        /// <summary>
        /// PKACR.
        /// </summary>
        public const string PKACR = "PKACR";

        /// <summary>
        /// PKCRR.
        /// </summary>
        public const string PKCRR = "PKCRR";

        /// <summary>
        /// PK74ULICR.
        /// </summary>
        public const string PK74ULICR = "PK74ULICR";

        /// <summary>
        /// PKURDT.
        /// </summary>
        public const string PKURDT = "PKURDT";

        /// <summary>
        /// PKURAB.
        /// </summary>
        public const string PKURAB = "PKURAB";

        /// <summary>
        /// PKURRF.
        /// </summary>
        public const string PKURRF = "PKURRF";

        /// <summary>
        /// PKUSER.
        /// </summary>
        public const string PKUSER = "PKUSER";

        /// <summary>
        /// PKPID.
        /// </summary>
        public const string PKPID = "PKPID";

        /// <summary>
        /// PKUPMJ.
        /// </summary>
        public const string PKUPMJ = "PKUPMJ";

        /// <summary>
        /// PKUPMT.
        /// </summary>
        public const string PKUPMT = "PKUPMT";

        /// <summary>
        /// PKJOBN.
        /// </summary>
        public const string PKJOBN = "PKJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U25BT";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PKFETP", "PKFETP", JdeDataType.String, 6, true, true),
        new JdeField("PKDOCO", "PKDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PKAN8", "PKAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PKMCU", "PKMCU", JdeDataType.String, 24, true, true),
        new JdeField("PKGLC", "PKGLC", JdeDataType.String, 8, true, true),
        new JdeField("PKAGSN", "PKAGSN", JdeDataType.Numeric, null, true, true),
        new JdeField("PKLNID", "PKLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PK74UBKCD", "PK74UBKCD", JdeDataType.String, 6),
        new JdeField("PK74UCRCD", "PK74UCRCD", JdeDataType.String, 6),
        new JdeField("PKCRRM", "PKCRRM", JdeDataType.String, 2),
        new JdeField("PKACR", "PKACR", JdeDataType.Numeric),
        new JdeField("PKCRR", "PKCRR", JdeDataType.Numeric),
        new JdeField("PK74ULICR", "PK74ULICR", JdeDataType.Numeric),
        new JdeField("PKURDT", "PKURDT", JdeDataType.Numeric),
        new JdeField("PKURAB", "PKURAB", JdeDataType.Numeric),
        new JdeField("PKURRF", "PKURRF", JdeDataType.String, 30),
        new JdeField("PKUSER", "PKUSER", JdeDataType.String, 20),
        new JdeField("PKPID", "PKPID", JdeDataType.String, 20),
        new JdeField("PKUPMJ", "PKUPMJ", JdeDataType.Numeric),
        new JdeField("PKUPMT", "PKUPMT", JdeDataType.Numeric),
        new JdeField("PKJOBN", "PKJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U25BT_0", "Primary Key on PKFETP, PKDOCO, PKAN8, PKMCU, PKGLC, PKAGSN, PKLNID", new[] { "PKFETP", "PKDOCO", "PKAN8", "PKMCU", "PKGLC", "PKAGSN", "PKLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
