using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4303 - .
/// </summary>
public class F4303 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PKDOCO.
        /// </summary>
        public const string PKDOCO = "PKDOCO";

        /// <summary>
        /// PKDCTO.
        /// </summary>
        public const string PKDCTO = "PKDCTO";

        /// <summary>
        /// PKKCOO.
        /// </summary>
        public const string PKKCOO = "PKKCOO";

        /// <summary>
        /// PKLGTY.
        /// </summary>
        public const string PKLGTY = "PKLGTY";

        /// <summary>
        /// PKLGNO.
        /// </summary>
        public const string PKLGNO = "PKLGNO";

        /// <summary>
        /// PKDL01.
        /// </summary>
        public const string PKDL01 = "PKDL01";

        /// <summary>
        /// PKEXR.
        /// </summary>
        public const string PKEXR = "PKEXR";

        /// <summary>
        /// PKISSU.
        /// </summary>
        public const string PKISSU = "PKISSU";

        /// <summary>
        /// PKEXPR.
        /// </summary>
        public const string PKEXPR = "PKEXPR";

        /// <summary>
        /// PKREQR.
        /// </summary>
        public const string PKREQR = "PKREQR";

        /// <summary>
        /// PKSTSC.
        /// </summary>
        public const string PKSTSC = "PKSTSC";

        /// <summary>
        /// PKPAYE.
        /// </summary>
        public const string PKPAYE = "PKPAYE";

        /// <summary>
        /// PKRPT1.
        /// </summary>
        public const string PKRPT1 = "PKRPT1";

        /// <summary>
        /// PKRPT2.
        /// </summary>
        public const string PKRPT2 = "PKRPT2";

        /// <summary>
        /// PKRPT3.
        /// </summary>
        public const string PKRPT3 = "PKRPT3";

        /// <summary>
        /// PKAN8.
        /// </summary>
        public const string PKAN8 = "PKAN8";

        /// <summary>
        /// PKSBCD.
        /// </summary>
        public const string PKSBCD = "PKSBCD";

        /// <summary>
        /// PKU.
        /// </summary>
        public const string PKU = "PKU";

        /// <summary>
        /// PKUM.
        /// </summary>
        public const string PKUM = "PKUM";

        /// <summary>
        /// PKUSD1.
        /// </summary>
        public const string PKUSD1 = "PKUSD1";

        /// <summary>
        /// PKCO.
        /// </summary>
        public const string PKCO = "PKCO";

        /// <summary>
        /// PKMCU.
        /// </summary>
        public const string PKMCU = "PKMCU";

        /// <summary>
        /// PKCONO.
        /// </summary>
        public const string PKCONO = "PKCONO";

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
        /// PKJOBN.
        /// </summary>
        public const string PKJOBN = "PKJOBN";

        /// <summary>
        /// PKUPMT.
        /// </summary>
        public const string PKUPMT = "PKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4303";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PKDOCO", "PKDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PKDCTO", "PKDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PKKCOO", "PKKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PKLGTY", "PKLGTY", JdeDataType.String, 2, true, true),
        new JdeField("PKLGNO", "PKLGNO", JdeDataType.Numeric, null, true, true),
        new JdeField("PKDL01", "PKDL01", JdeDataType.String, 60),
        new JdeField("PKEXR", "PKEXR", JdeDataType.String, 60),
        new JdeField("PKISSU", "PKISSU", JdeDataType.Numeric),
        new JdeField("PKEXPR", "PKEXPR", JdeDataType.Numeric),
        new JdeField("PKREQR", "PKREQR", JdeDataType.Numeric),
        new JdeField("PKSTSC", "PKSTSC", JdeDataType.String, 2),
        new JdeField("PKPAYE", "PKPAYE", JdeDataType.String, 2),
        new JdeField("PKRPT1", "PKRPT1", JdeDataType.String, 6),
        new JdeField("PKRPT2", "PKRPT2", JdeDataType.String, 6),
        new JdeField("PKRPT3", "PKRPT3", JdeDataType.String, 6),
        new JdeField("PKAN8", "PKAN8", JdeDataType.Numeric),
        new JdeField("PKSBCD", "PKSBCD", JdeDataType.String, 2),
        new JdeField("PKU", "PKU", JdeDataType.Numeric),
        new JdeField("PKUM", "PKUM", JdeDataType.String, 4),
        new JdeField("PKUSD1", "PKUSD1", JdeDataType.Numeric),
        new JdeField("PKCO", "PKCO", JdeDataType.String, 10),
        new JdeField("PKMCU", "PKMCU", JdeDataType.String, 24, true, true),
        new JdeField("PKCONO", "PKCONO", JdeDataType.Numeric, null, true, true),
        new JdeField("PKUSER", "PKUSER", JdeDataType.String, 20),
        new JdeField("PKPID", "PKPID", JdeDataType.String, 20),
        new JdeField("PKUPMJ", "PKUPMJ", JdeDataType.Numeric),
        new JdeField("PKJOBN", "PKJOBN", JdeDataType.String, 20),
        new JdeField("PKUPMT", "PKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4303_0", "Primary Key on PKDOCO, PKDCTO, PKKCOO, PKLGTY, PKLGNO, PKMCU, PKCONO", new[] { "PKDOCO", "PKDCTO", "PKKCOO", "PKLGTY", "PKLGNO", "PKMCU", "PKCONO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4303_3", "Index on PKDOCO, PKDCTO, PKKCOO, PKLGTY, SYS_NC00029$", new[] { "PKDOCO", "PKDCTO", "PKKCOO", "PKLGTY", "SYS_NC00029$" }),
        new JdeIndex("F4303_4", "Index on PKMCU, PKCONO, PKLGTY, PKLGNO, PKDOCO, PKDCTO, PKKCOO", new[] { "PKMCU", "PKCONO", "PKLGTY", "PKLGNO", "PKDOCO", "PKDCTO", "PKKCOO" })
    };
}
