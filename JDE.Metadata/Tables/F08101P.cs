using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08101P - .
/// </summary>
public class F08101P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HPFY.
        /// </summary>
        public const string HPFY = "HPFY";

        /// <summary>
        /// HPPOS.
        /// </summary>
        public const string HPPOS = "HPPOS";

        /// <summary>
        /// HPMCU.
        /// </summary>
        public const string HPMCU = "HPMCU";

        /// <summary>
        /// HPDL01.
        /// </summary>
        public const string HPDL01 = "HPDL01";

        /// <summary>
        /// HPDL02.
        /// </summary>
        public const string HPDL02 = "HPDL02";

        /// <summary>
        /// HPEFTS.
        /// </summary>
        public const string HPEFTS = "HPEFTS";

        /// <summary>
        /// HPEFST.
        /// </summary>
        public const string HPEFST = "HPEFST";

        /// <summary>
        /// HPPSTC.
        /// </summary>
        public const string HPPSTC = "HPPSTC";

        /// <summary>
        /// HPCURB.
        /// </summary>
        public const string HPCURB = "HPCURB";

        /// <summary>
        /// HPBFTE.
        /// </summary>
        public const string HPBFTE = "HPBFTE";

        /// <summary>
        /// HPHRB.
        /// </summary>
        public const string HPHRB = "HPHRB";

        /// <summary>
        /// HPPMCU.
        /// </summary>
        public const string HPPMCU = "HPPMCU";

        /// <summary>
        /// HPPPOS.
        /// </summary>
        public const string HPPPOS = "HPPPOS";

        /// <summary>
        /// HPJBCD.
        /// </summary>
        public const string HPJBCD = "HPJBCD";

        /// <summary>
        /// HPJBST.
        /// </summary>
        public const string HPJBST = "HPJBST";

        /// <summary>
        /// HPSLOC.
        /// </summary>
        public const string HPSLOC = "HPSLOC";

        /// <summary>
        /// HPPX01.
        /// </summary>
        public const string HPPX01 = "HPPX01";

        /// <summary>
        /// HPPX02.
        /// </summary>
        public const string HPPX02 = "HPPX02";

        /// <summary>
        /// HPPX03.
        /// </summary>
        public const string HPPX03 = "HPPX03";

        /// <summary>
        /// HPPX04.
        /// </summary>
        public const string HPPX04 = "HPPX04";

        /// <summary>
        /// HPPX05.
        /// </summary>
        public const string HPPX05 = "HPPX05";

        /// <summary>
        /// HPUSER.
        /// </summary>
        public const string HPUSER = "HPUSER";

        /// <summary>
        /// HPPID.
        /// </summary>
        public const string HPPID = "HPPID";

        /// <summary>
        /// HPUPMJ.
        /// </summary>
        public const string HPUPMJ = "HPUPMJ";

        /// <summary>
        /// HPJOBN.
        /// </summary>
        public const string HPJOBN = "HPJOBN";

        /// <summary>
        /// HPHMCU.
        /// </summary>
        public const string HPHMCU = "HPHMCU";

        /// <summary>
        /// HPTPOS.
        /// </summary>
        public const string HPTPOS = "HPTPOS";

        /// <summary>
        /// HPSPAM.
        /// </summary>
        public const string HPSPAM = "HPSPAM";

        /// <summary>
        /// HPPBSD.
        /// </summary>
        public const string HPPBSD = "HPPBSD";

        /// <summary>
        /// HPPSST.
        /// </summary>
        public const string HPPSST = "HPPSST";

        /// <summary>
        /// HPPSSD.
        /// </summary>
        public const string HPPSSD = "HPPSSD";

        /// <summary>
        /// HPHDCT.
        /// </summary>
        public const string HPHDCT = "HPHDCT";

        /// <summary>
        /// HPEFFB.
        /// </summary>
        public const string HPEFFB = "HPEFFB";

        /// <summary>
        /// HPEFHR.
        /// </summary>
        public const string HPEFHR = "HPEFHR";

        /// <summary>
        /// HPFTEE.
        /// </summary>
        public const string HPFTEE = "HPFTEE";
    }

    /// <inheritdoc />
    public override string TableName => "F08101P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HPFY", "HPFY", JdeDataType.Numeric, null, true, true),
        new JdeField("HPPOS", "HPPOS", JdeDataType.String, 16, true, true),
        new JdeField("HPMCU", "HPMCU", JdeDataType.String, 24),
        new JdeField("HPDL01", "HPDL01", JdeDataType.String, 60),
        new JdeField("HPDL02", "HPDL02", JdeDataType.String, 60),
        new JdeField("HPEFTS", "HPEFTS", JdeDataType.Numeric),
        new JdeField("HPEFST", "HPEFST", JdeDataType.Numeric),
        new JdeField("HPPSTC", "HPPSTC", JdeDataType.String, 2),
        new JdeField("HPCURB", "HPCURB", JdeDataType.Numeric),
        new JdeField("HPBFTE", "HPBFTE", JdeDataType.Numeric),
        new JdeField("HPHRB", "HPHRB", JdeDataType.Numeric),
        new JdeField("HPPMCU", "HPPMCU", JdeDataType.String, 24),
        new JdeField("HPPPOS", "HPPPOS", JdeDataType.String, 16),
        new JdeField("HPJBCD", "HPJBCD", JdeDataType.String, 12),
        new JdeField("HPJBST", "HPJBST", JdeDataType.String, 8),
        new JdeField("HPSLOC", "HPSLOC", JdeDataType.String, 16),
        new JdeField("HPPX01", "HPPX01", JdeDataType.String, 6),
        new JdeField("HPPX02", "HPPX02", JdeDataType.String, 6),
        new JdeField("HPPX03", "HPPX03", JdeDataType.String, 6),
        new JdeField("HPPX04", "HPPX04", JdeDataType.String, 6),
        new JdeField("HPPX05", "HPPX05", JdeDataType.String, 6),
        new JdeField("HPUSER", "HPUSER", JdeDataType.String, 20),
        new JdeField("HPPID", "HPPID", JdeDataType.String, 20),
        new JdeField("HPUPMJ", "HPUPMJ", JdeDataType.Numeric),
        new JdeField("HPJOBN", "HPJOBN", JdeDataType.String, 20),
        new JdeField("HPHMCU", "HPHMCU", JdeDataType.String, 24, true, true),
        new JdeField("HPTPOS", "HPTPOS", JdeDataType.String, 6),
        new JdeField("HPSPAM", "HPSPAM", JdeDataType.Numeric),
        new JdeField("HPPBSD", "HPPBSD", JdeDataType.Numeric),
        new JdeField("HPPSST", "HPPSST", JdeDataType.String, 2),
        new JdeField("HPPSSD", "HPPSSD", JdeDataType.Numeric),
        new JdeField("HPHDCT", "HPHDCT", JdeDataType.Numeric),
        new JdeField("HPEFFB", "HPEFFB", JdeDataType.Numeric),
        new JdeField("HPEFHR", "HPEFHR", JdeDataType.Numeric),
        new JdeField("HPFTEE", "HPFTEE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08101P_0", "Primary Key on HPFY, HPHMCU, HPPOS", new[] { "HPFY", "HPHMCU", "HPPOS" }, isUnique: true, isPrimaryKey: true)
    };
}
