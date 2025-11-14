using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I4210 - .
/// </summary>
public class F75I4210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FTDCTO.
        /// </summary>
        public const string FTDCTO = "FTDCTO";

        /// <summary>
        /// FTI75STN.
        /// </summary>
        public const string FTI75STN = "FTI75STN";

        /// <summary>
        /// FTDOCO.
        /// </summary>
        public const string FTDOCO = "FTDOCO";

        /// <summary>
        /// FTKCOO.
        /// </summary>
        public const string FTKCOO = "FTKCOO";

        /// <summary>
        /// FTYFRMTY.
        /// </summary>
        public const string FTYFRMTY = "FTYFRMTY";

        /// <summary>
        /// FTKCO.
        /// </summary>
        public const string FTKCO = "FTKCO";

        /// <summary>
        /// FTI75FNBR.
        /// </summary>
        public const string FTI75FNBR = "FTI75FNBR";

        /// <summary>
        /// FTI75FRD.
        /// </summary>
        public const string FTI75FRD = "FTI75FRD";

        /// <summary>
        /// FTADSO.
        /// </summary>
        public const string FTADSO = "FTADSO";

        /// <summary>
        /// FTREM1.
        /// </summary>
        public const string FTREM1 = "FTREM1";

        /// <summary>
        /// FTAVCO.
        /// </summary>
        public const string FTAVCO = "FTAVCO";

        /// <summary>
        /// FTUSER.
        /// </summary>
        public const string FTUSER = "FTUSER";

        /// <summary>
        /// FTPID.
        /// </summary>
        public const string FTPID = "FTPID";

        /// <summary>
        /// FTJOBN.
        /// </summary>
        public const string FTJOBN = "FTJOBN";

        /// <summary>
        /// FTUPMJ.
        /// </summary>
        public const string FTUPMJ = "FTUPMJ";

        /// <summary>
        /// FTUPMT.
        /// </summary>
        public const string FTUPMT = "FTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I4210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FTDCTO", "FTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("FTI75STN", "FTI75STN", JdeDataType.String, 60, true, true),
        new JdeField("FTDOCO", "FTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("FTKCOO", "FTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("FTYFRMTY", "FTYFRMTY", JdeDataType.String, 20),
        new JdeField("FTKCO", "FTKCO", JdeDataType.String, 10),
        new JdeField("FTI75FNBR", "FTI75FNBR", JdeDataType.String, 60),
        new JdeField("FTI75FRD", "FTI75FRD", JdeDataType.Numeric),
        new JdeField("FTADSO", "FTADSO", JdeDataType.String, 6),
        new JdeField("FTREM1", "FTREM1", JdeDataType.String, 80),
        new JdeField("FTAVCO", "FTAVCO", JdeDataType.Numeric),
        new JdeField("FTUSER", "FTUSER", JdeDataType.String, 20),
        new JdeField("FTPID", "FTPID", JdeDataType.String, 20),
        new JdeField("FTJOBN", "FTJOBN", JdeDataType.String, 20),
        new JdeField("FTUPMJ", "FTUPMJ", JdeDataType.Numeric),
        new JdeField("FTUPMT", "FTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I4210_0", "Primary Key on FTDCTO, FTI75STN, FTDOCO, FTKCOO", new[] { "FTDCTO", "FTI75STN", "FTDOCO", "FTKCOO" }, isUnique: true, isPrimaryKey: true)
    };
}
