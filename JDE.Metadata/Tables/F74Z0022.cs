using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Z0022 - .
/// </summary>
public class F74Z0022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CZUKID.
        /// </summary>
        public const string CZUKID = "CZUKID";

        /// <summary>
        /// CZDOCO.
        /// </summary>
        public const string CZDOCO = "CZDOCO";

        /// <summary>
        /// CZDCTO.
        /// </summary>
        public const string CZDCTO = "CZDCTO";

        /// <summary>
        /// CZSFXO.
        /// </summary>
        public const string CZSFXO = "CZSFXO";

        /// <summary>
        /// CZLNID.
        /// </summary>
        public const string CZLNID = "CZLNID";

        /// <summary>
        /// CZKCOO.
        /// </summary>
        public const string CZKCOO = "CZKCOO";

        /// <summary>
        /// CZ74ZSNT.
        /// </summary>
        public const string CZ74ZSNT = "CZ74ZSNT";

        /// <summary>
        /// CZZ74CC.
        /// </summary>
        public const string CZZ74CC = "CZZ74CC";

        /// <summary>
        /// CZ74ZMC.
        /// </summary>
        public const string CZ74ZMC = "CZ74ZMC";

        /// <summary>
        /// CZ74ZTT.
        /// </summary>
        public const string CZ74ZTT = "CZ74ZTT";

        /// <summary>
        /// CZUPMT.
        /// </summary>
        public const string CZUPMT = "CZUPMT";

        /// <summary>
        /// CZUPMJ.
        /// </summary>
        public const string CZUPMJ = "CZUPMJ";

        /// <summary>
        /// CZJOBN.
        /// </summary>
        public const string CZJOBN = "CZJOBN";

        /// <summary>
        /// CZPID.
        /// </summary>
        public const string CZPID = "CZPID";

        /// <summary>
        /// CZUSER.
        /// </summary>
        public const string CZUSER = "CZUSER";

        /// <summary>
        /// CZFLAG.
        /// </summary>
        public const string CZFLAG = "CZFLAG";

        /// <summary>
        /// CZDATF01.
        /// </summary>
        public const string CZDATF01 = "CZDATF01";

        /// <summary>
        /// CZDEPFUT2.
        /// </summary>
        public const string CZDEPFUT2 = "CZDEPFUT2";

        /// <summary>
        /// CZACTFU1.
        /// </summary>
        public const string CZACTFU1 = "CZACTFU1";
    }

    /// <inheritdoc />
    public override string TableName => "F74Z0022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CZUKID", "CZUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CZDOCO", "CZDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CZDCTO", "CZDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CZSFXO", "CZSFXO", JdeDataType.String, 6, true, true),
        new JdeField("CZLNID", "CZLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CZKCOO", "CZKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CZ74ZSNT", "CZ74ZSNT", JdeDataType.String, 12),
        new JdeField("CZZ74CC", "CZZ74CC", JdeDataType.String, 6),
        new JdeField("CZ74ZMC", "CZ74ZMC", JdeDataType.String, 12),
        new JdeField("CZ74ZTT", "CZ74ZTT", JdeDataType.String, 12),
        new JdeField("CZUPMT", "CZUPMT", JdeDataType.Numeric),
        new JdeField("CZUPMJ", "CZUPMJ", JdeDataType.Numeric),
        new JdeField("CZJOBN", "CZJOBN", JdeDataType.String, 20),
        new JdeField("CZPID", "CZPID", JdeDataType.String, 20),
        new JdeField("CZUSER", "CZUSER", JdeDataType.String, 20),
        new JdeField("CZFLAG", "CZFLAG", JdeDataType.String, 2),
        new JdeField("CZDATF01", "CZDATF01", JdeDataType.Numeric),
        new JdeField("CZDEPFUT2", "CZDEPFUT2", JdeDataType.String, 60),
        new JdeField("CZACTFU1", "CZACTFU1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Z0022_0", "Primary Key on CZUKID, CZDOCO, CZDCTO, CZSFXO, CZLNID, CZKCOO", new[] { "CZUKID", "CZDOCO", "CZDCTO", "CZSFXO", "CZLNID", "CZKCOO" }, isUnique: true, isPrimaryKey: true)
    };
}
