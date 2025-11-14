using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H790 - .
/// </summary>
public class F44H790 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HMHBMCUS.
        /// </summary>
        public const string HMHBMCUS = "HMHBMCUS";

        /// <summary>
        /// HMHBLOT.
        /// </summary>
        public const string HMHBLOT = "HMHBLOT";

        /// <summary>
        /// HMHBMSID.
        /// </summary>
        public const string HMHBMSID = "HMHBMSID";

        /// <summary>
        /// HMMSSEQ.
        /// </summary>
        public const string HMMSSEQ = "HMMSSEQ";

        /// <summary>
        /// HMDL01.
        /// </summary>
        public const string HMDL01 = "HMDL01";

        /// <summary>
        /// HMPASQ.
        /// </summary>
        public const string HMPASQ = "HMPASQ";

        /// <summary>
        /// HMAN8V.
        /// </summary>
        public const string HMAN8V = "HMAN8V";

        /// <summary>
        /// HMHPF.
        /// </summary>
        public const string HMHPF = "HMHPF";

        /// <summary>
        /// HMMSC.
        /// </summary>
        public const string HMMSC = "HMMSC";

        /// <summary>
        /// HMNDAP.
        /// </summary>
        public const string HMNDAP = "HMNDAP";

        /// <summary>
        /// HMPNST.
        /// </summary>
        public const string HMPNST = "HMPNST";

        /// <summary>
        /// HMOSF.
        /// </summary>
        public const string HMOSF = "HMOSF";

        /// <summary>
        /// HMODWD.
        /// </summary>
        public const string HMODWD = "HMODWD";

        /// <summary>
        /// HMODCD.
        /// </summary>
        public const string HMODCD = "HMODCD";

        /// <summary>
        /// HMCSHST.
        /// </summary>
        public const string HMCSHST = "HMCSHST";

        /// <summary>
        /// HMCSHF.
        /// </summary>
        public const string HMCSHF = "HMCSHF";

        /// <summary>
        /// HMRDWD.
        /// </summary>
        public const string HMRDWD = "HMRDWD";

        /// <summary>
        /// HMRDCD.
        /// </summary>
        public const string HMRDCD = "HMRDCD";

        /// <summary>
        /// HMASJ.
        /// </summary>
        public const string HMASJ = "HMASJ";

        /// <summary>
        /// HMATFN.
        /// </summary>
        public const string HMATFN = "HMATFN";

        /// <summary>
        /// HMADWD.
        /// </summary>
        public const string HMADWD = "HMADWD";

        /// <summary>
        /// HMADCD.
        /// </summary>
        public const string HMADCD = "HMADCD";

        /// <summary>
        /// HMDRC.
        /// </summary>
        public const string HMDRC = "HMDRC";

        /// <summary>
        /// HMDDL01.
        /// </summary>
        public const string HMDDL01 = "HMDDL01";

        /// <summary>
        /// HMMSNOTE.
        /// </summary>
        public const string HMMSNOTE = "HMMSNOTE";

        /// <summary>
        /// HMSCHTMPT.
        /// </summary>
        public const string HMSCHTMPT = "HMSCHTMPT";

        /// <summary>
        /// HMAPRV.
        /// </summary>
        public const string HMAPRV = "HMAPRV";

        /// <summary>
        /// HMHBST1.
        /// </summary>
        public const string HMHBST1 = "HMHBST1";

        /// <summary>
        /// HMHBST2.
        /// </summary>
        public const string HMHBST2 = "HMHBST2";

        /// <summary>
        /// HMHBST3.
        /// </summary>
        public const string HMHBST3 = "HMHBST3";

        /// <summary>
        /// HMHBST4.
        /// </summary>
        public const string HMHBST4 = "HMHBST4";

        /// <summary>
        /// HMHBST5.
        /// </summary>
        public const string HMHBST5 = "HMHBST5";

        /// <summary>
        /// HMGS3A.
        /// </summary>
        public const string HMGS3A = "HMGS3A";

        /// <summary>
        /// HMGS3B.
        /// </summary>
        public const string HMGS3B = "HMGS3B";

        /// <summary>
        /// HMGS3C.
        /// </summary>
        public const string HMGS3C = "HMGS3C";

        /// <summary>
        /// HMGS3D.
        /// </summary>
        public const string HMGS3D = "HMGS3D";

        /// <summary>
        /// HMGS3E.
        /// </summary>
        public const string HMGS3E = "HMGS3E";

        /// <summary>
        /// HMCRTU.
        /// </summary>
        public const string HMCRTU = "HMCRTU";

        /// <summary>
        /// HMCRTJ.
        /// </summary>
        public const string HMCRTJ = "HMCRTJ";

        /// <summary>
        /// HMWRKSTNID.
        /// </summary>
        public const string HMWRKSTNID = "HMWRKSTNID";

        /// <summary>
        /// HMHBOPID.
        /// </summary>
        public const string HMHBOPID = "HMHBOPID";

        /// <summary>
        /// HMUPMB.
        /// </summary>
        public const string HMUPMB = "HMUPMB";

        /// <summary>
        /// HMUPMJ.
        /// </summary>
        public const string HMUPMJ = "HMUPMJ";

        /// <summary>
        /// HMUPMT.
        /// </summary>
        public const string HMUPMT = "HMUPMT";

        /// <summary>
        /// HMJOBN.
        /// </summary>
        public const string HMJOBN = "HMJOBN";

        /// <summary>
        /// HMPID.
        /// </summary>
        public const string HMPID = "HMPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H790";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HMHBMCUS", "HMHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("HMHBLOT", "HMHBLOT", JdeDataType.String, 8, true, true),
        new JdeField("HMHBMSID", "HMHBMSID", JdeDataType.String, 8, true, true),
        new JdeField("HMMSSEQ", "HMMSSEQ", JdeDataType.String, 8),
        new JdeField("HMDL01", "HMDL01", JdeDataType.String, 60),
        new JdeField("HMPASQ", "HMPASQ", JdeDataType.Numeric),
        new JdeField("HMAN8V", "HMAN8V", JdeDataType.Numeric),
        new JdeField("HMHPF", "HMHPF", JdeDataType.String, 2),
        new JdeField("HMMSC", "HMMSC", JdeDataType.String, 2),
        new JdeField("HMNDAP", "HMNDAP", JdeDataType.Numeric),
        new JdeField("HMPNST", "HMPNST", JdeDataType.Numeric),
        new JdeField("HMOSF", "HMOSF", JdeDataType.Numeric),
        new JdeField("HMODWD", "HMODWD", JdeDataType.Numeric),
        new JdeField("HMODCD", "HMODCD", JdeDataType.Numeric),
        new JdeField("HMCSHST", "HMCSHST", JdeDataType.Numeric),
        new JdeField("HMCSHF", "HMCSHF", JdeDataType.Numeric),
        new JdeField("HMRDWD", "HMRDWD", JdeDataType.Numeric),
        new JdeField("HMRDCD", "HMRDCD", JdeDataType.Numeric),
        new JdeField("HMASJ", "HMASJ", JdeDataType.Numeric),
        new JdeField("HMATFN", "HMATFN", JdeDataType.Numeric),
        new JdeField("HMADWD", "HMADWD", JdeDataType.Numeric),
        new JdeField("HMADCD", "HMADCD", JdeDataType.Numeric),
        new JdeField("HMDRC", "HMDRC", JdeDataType.String, 20),
        new JdeField("HMDDL01", "HMDDL01", JdeDataType.String, 60),
        new JdeField("HMMSNOTE", "HMMSNOTE", JdeDataType.String, 160),
        new JdeField("HMSCHTMPT", "HMSCHTMPT", JdeDataType.String, 24),
        new JdeField("HMAPRV", "HMAPRV", JdeDataType.Numeric),
        new JdeField("HMHBST1", "HMHBST1", JdeDataType.String, 2),
        new JdeField("HMHBST2", "HMHBST2", JdeDataType.String, 2),
        new JdeField("HMHBST3", "HMHBST3", JdeDataType.String, 2),
        new JdeField("HMHBST4", "HMHBST4", JdeDataType.String, 2),
        new JdeField("HMHBST5", "HMHBST5", JdeDataType.String, 2),
        new JdeField("HMGS3A", "HMGS3A", JdeDataType.String, 60),
        new JdeField("HMGS3B", "HMGS3B", JdeDataType.String, 60),
        new JdeField("HMGS3C", "HMGS3C", JdeDataType.String, 60),
        new JdeField("HMGS3D", "HMGS3D", JdeDataType.String, 60),
        new JdeField("HMGS3E", "HMGS3E", JdeDataType.String, 60),
        new JdeField("HMCRTU", "HMCRTU", JdeDataType.String, 20),
        new JdeField("HMCRTJ", "HMCRTJ", JdeDataType.Numeric),
        new JdeField("HMWRKSTNID", "HMWRKSTNID", JdeDataType.String, 20),
        new JdeField("HMHBOPID", "HMHBOPID", JdeDataType.String, 20),
        new JdeField("HMUPMB", "HMUPMB", JdeDataType.String, 20),
        new JdeField("HMUPMJ", "HMUPMJ", JdeDataType.Numeric),
        new JdeField("HMUPMT", "HMUPMT", JdeDataType.Numeric),
        new JdeField("HMJOBN", "HMJOBN", JdeDataType.String, 20),
        new JdeField("HMPID", "HMPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H790_0", "Primary Key on HMHBMCUS, HMHBLOT, HMHBMSID", new[] { "HMHBMCUS", "HMHBLOT", "HMHBMSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H790_2", "Index on HMHBMCUS, HMHBLOT, HMMSSEQ, HMHBMSID", new[] { "HMHBMCUS", "HMHBLOT", "HMMSSEQ", "HMHBMSID" }),
        new JdeIndex("F44H790_3", "Index on HMHBMCUS, HMHBLOT, HMDL01, HMHBMSID", new[] { "HMHBMCUS", "HMHBLOT", "HMDL01", "HMHBMSID" })
    };
}
