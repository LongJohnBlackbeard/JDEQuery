using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U012T - .
/// </summary>
public class F74U012T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PJDOCO.
        /// </summary>
        public const string PJDOCO = "PJDOCO";

        /// <summary>
        /// PJLSVR.
        /// </summary>
        public const string PJLSVR = "PJLSVR";

        /// <summary>
        /// PJBCI.
        /// </summary>
        public const string PJBCI = "PJBCI";

        /// <summary>
        /// PJ74UBLPTN.
        /// </summary>
        public const string PJ74UBLPTN = "PJ74UBLPTN";

        /// <summary>
        /// PJ74UPYMTH.
        /// </summary>
        public const string PJ74UPYMTH = "PJ74UPYMTH";

        /// <summary>
        /// PJURCD.
        /// </summary>
        public const string PJURCD = "PJURCD";

        /// <summary>
        /// PJURDT.
        /// </summary>
        public const string PJURDT = "PJURDT";

        /// <summary>
        /// PJURAT.
        /// </summary>
        public const string PJURAT = "PJURAT";

        /// <summary>
        /// PJURAB.
        /// </summary>
        public const string PJURAB = "PJURAB";

        /// <summary>
        /// PJURRF.
        /// </summary>
        public const string PJURRF = "PJURRF";

        /// <summary>
        /// PJUSER.
        /// </summary>
        public const string PJUSER = "PJUSER";

        /// <summary>
        /// PJPID.
        /// </summary>
        public const string PJPID = "PJPID";

        /// <summary>
        /// PJUPMJ.
        /// </summary>
        public const string PJUPMJ = "PJUPMJ";

        /// <summary>
        /// PJUPMT.
        /// </summary>
        public const string PJUPMT = "PJUPMT";

        /// <summary>
        /// PJJOBN.
        /// </summary>
        public const string PJJOBN = "PJJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U012T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PJDOCO", "PJDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PJLSVR", "PJLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("PJBCI", "PJBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("PJ74UBLPTN", "PJ74UBLPTN", JdeDataType.String, 10),
        new JdeField("PJ74UPYMTH", "PJ74UPYMTH", JdeDataType.String, 6),
        new JdeField("PJURCD", "PJURCD", JdeDataType.String, 4),
        new JdeField("PJURDT", "PJURDT", JdeDataType.Numeric),
        new JdeField("PJURAT", "PJURAT", JdeDataType.Numeric),
        new JdeField("PJURAB", "PJURAB", JdeDataType.Numeric),
        new JdeField("PJURRF", "PJURRF", JdeDataType.String, 30),
        new JdeField("PJUSER", "PJUSER", JdeDataType.String, 20),
        new JdeField("PJPID", "PJPID", JdeDataType.String, 20),
        new JdeField("PJUPMJ", "PJUPMJ", JdeDataType.Numeric),
        new JdeField("PJUPMT", "PJUPMT", JdeDataType.Numeric),
        new JdeField("PJJOBN", "PJJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U012T_0", "Primary Key on PJDOCO, PJLSVR, PJBCI", new[] { "PJDOCO", "PJLSVR", "PJBCI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U012T_2", "Index on PJ74UBLPTN", new[] { "PJ74UBLPTN" })
    };
}
