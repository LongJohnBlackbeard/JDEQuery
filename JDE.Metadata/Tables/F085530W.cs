using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085530W - .
/// </summary>
public class F085530W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPAN8.
        /// </summary>
        public const string CPAN8 = "CPAN8";

        /// <summary>
        /// CPSEQ#.
        /// </summary>
        public const string CPSEQ_ = "CPSEQ#";

        /// <summary>
        /// CPSBGR.
        /// </summary>
        public const string CPSBGR = "CPSBGR";

        /// <summary>
        /// CPDL01.
        /// </summary>
        public const string CPDL01 = "CPDL01";

        /// <summary>
        /// CPPLAN.
        /// </summary>
        public const string CPPLAN = "CPPLAN";

        /// <summary>
        /// CPAOPT.
        /// </summary>
        public const string CPAOPT = "CPAOPT";

        /// <summary>
        /// CPDS50.
        /// </summary>
        public const string CPDS50 = "CPDS50";

        /// <summary>
        /// CPEFT.
        /// </summary>
        public const string CPEFT = "CPEFT";

        /// <summary>
        /// CPEFTE.
        /// </summary>
        public const string CPEFTE = "CPEFTE";

        /// <summary>
        /// CPPCOS.
        /// </summary>
        public const string CPPCOS = "CPPCOS";

        /// <summary>
        /// CPPCRE.
        /// </summary>
        public const string CPPCRE = "CPPCRE";

        /// <summary>
        /// CPDBEN.
        /// </summary>
        public const string CPDBEN = "CPDBEN";

        /// <summary>
        /// CPPCPF.
        /// </summary>
        public const string CPPCPF = "CPPCPF";

        /// <summary>
        /// CPPCPVST.
        /// </summary>
        public const string CPPCPVST = "CPPCPVST";

        /// <summary>
        /// CPEEFC.
        /// </summary>
        public const string CPEEFC = "CPEEFC";

        /// <summary>
        /// CPERAM.
        /// </summary>
        public const string CPERAM = "CPERAM";

        /// <summary>
        /// CPBRTM.
        /// </summary>
        public const string CPBRTM = "CPBRTM";

        /// <summary>
        /// CPDRTM.
        /// </summary>
        public const string CPDRTM = "CPDRTM";

        /// <summary>
        /// CPCATY.
        /// </summary>
        public const string CPCATY = "CPCATY";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPUPMJ.
        /// </summary>
        public const string CPUPMJ = "CPUPMJ";

        /// <summary>
        /// CPUPMT.
        /// </summary>
        public const string CPUPMT = "CPUPMT";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPSEQN.
        /// </summary>
        public const string CPSEQN = "CPSEQN";

        /// <summary>
        /// CPJOBN.
        /// </summary>
        public const string CPJOBN = "CPJOBN";

        /// <summary>
        /// CPBCATCL.
        /// </summary>
        public const string CPBCATCL = "CPBCATCL";

        /// <summary>
        /// CPPLNGRP.
        /// </summary>
        public const string CPPLNGRP = "CPPLNGRP";

        /// <summary>
        /// CPPCP#.
        /// </summary>
        public const string CPPCP_ = "CPPCP#";

        /// <summary>
        /// CPSIPG.
        /// </summary>
        public const string CPSIPG = "CPSIPG";

        /// <summary>
        /// CPNPPLFL.
        /// </summary>
        public const string CPNPPLFL = "CPNPPLFL";
    }

    /// <inheritdoc />
    public override string TableName => "F085530W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPAN8", "CPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CPSEQ#", "CPSEQ#", JdeDataType.Numeric, null, true, true),
        new JdeField("CPSBGR", "CPSBGR", JdeDataType.String, 20, true, true),
        new JdeField("CPDL01", "CPDL01", JdeDataType.String, 60),
        new JdeField("CPPLAN", "CPPLAN", JdeDataType.String, 16, true, true),
        new JdeField("CPAOPT", "CPAOPT", JdeDataType.String, 6, true, true),
        new JdeField("CPDS50", "CPDS50", JdeDataType.String, 100),
        new JdeField("CPEFT", "CPEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("CPEFTE", "CPEFTE", JdeDataType.Numeric),
        new JdeField("CPPCOS", "CPPCOS", JdeDataType.Numeric),
        new JdeField("CPPCRE", "CPPCRE", JdeDataType.Numeric),
        new JdeField("CPDBEN", "CPDBEN", JdeDataType.String, 2),
        new JdeField("CPPCPF", "CPPCPF", JdeDataType.Numeric),
        new JdeField("CPPCPVST", "CPPCPVST", JdeDataType.String, 2),
        new JdeField("CPEEFC", "CPEEFC", JdeDataType.Numeric),
        new JdeField("CPERAM", "CPERAM", JdeDataType.Numeric),
        new JdeField("CPBRTM", "CPBRTM", JdeDataType.Numeric),
        new JdeField("CPDRTM", "CPDRTM", JdeDataType.Numeric),
        new JdeField("CPCATY", "CPCATY", JdeDataType.String, 2),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPUPMJ", "CPUPMJ", JdeDataType.Numeric),
        new JdeField("CPUPMT", "CPUPMT", JdeDataType.Numeric),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPSEQN", "CPSEQN", JdeDataType.Numeric),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPBCATCL", "CPBCATCL", JdeDataType.String, 6),
        new JdeField("CPPLNGRP", "CPPLNGRP", JdeDataType.String, 6),
        new JdeField("CPPCP#", "CPPCP#", JdeDataType.String, 40),
        new JdeField("CPSIPG", "CPSIPG", JdeDataType.String, 2),
        new JdeField("CPNPPLFL", "CPNPPLFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085530W_0", "Primary Key on CPAN8, CPSEQ#, CPSBGR, CPPLAN, CPAOPT, CPEFT", new[] { "CPAN8", "CPSEQ#", "CPSBGR", "CPPLAN", "CPAOPT", "CPEFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F085530W_2", "Index on CPAN8, CPBCATCL, CPSEQN, CPSEQ#, CPAOPT", new[] { "CPAN8", "CPBCATCL", "CPSEQN", "CPSEQ#", "CPAOPT" }),
        new JdeIndex("F085530W_4", "Index on CPAN8, SYS_NC00031$", new[] { "CPAN8", "SYS_NC00031$" })
    };
}
