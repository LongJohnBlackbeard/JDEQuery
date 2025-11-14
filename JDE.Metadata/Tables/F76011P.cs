using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76011P - .
/// </summary>
public class F76011P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRAN8.
        /// </summary>
        public const string PRAN8 = "PRAN8";

        /// <summary>
        /// PRBMUN.
        /// </summary>
        public const string PRBMUN = "PRBMUN";

        /// <summary>
        /// PRBICC.
        /// </summary>
        public const string PRBICC = "PRBICC";

        /// <summary>
        /// PRBIST.
        /// </summary>
        public const string PRBIST = "PRBIST";

        /// <summary>
        /// PRBIRP.
        /// </summary>
        public const string PRBIRP = "PRBIRP";

        /// <summary>
        /// PRBFII.
        /// </summary>
        public const string PRBFII = "PRBFII";

        /// <summary>
        /// PRBFIP.
        /// </summary>
        public const string PRBFIP = "PRBFIP";

        /// <summary>
        /// PRBFIS.
        /// </summary>
        public const string PRBFIS = "PRBFIS";

        /// <summary>
        /// PRBZFR.
        /// </summary>
        public const string PRBZFR = "PRBZFR";

        /// <summary>
        /// PRBISC.
        /// </summary>
        public const string PRBISC = "PRBISC";

        /// <summary>
        /// PRBCPF.
        /// </summary>
        public const string PRBCPF = "PRBCPF";

        /// <summary>
        /// PRBRG.
        /// </summary>
        public const string PRBRG = "PRBRG";

        /// <summary>
        /// PRBSOE.
        /// </summary>
        public const string PRBSOE = "PRBSOE";

        /// <summary>
        /// PRADDS.
        /// </summary>
        public const string PRADDS = "PRADDS";

        /// <summary>
        /// PRBAUT.
        /// </summary>
        public const string PRBAUT = "PRBAUT";

        /// <summary>
        /// PRCTY1.
        /// </summary>
        public const string PRCTY1 = "PRCTY1";

        /// <summary>
        /// PRSTCD.
        /// </summary>
        public const string PRSTCD = "PRSTCD";

        /// <summary>
        /// PRBNOP.
        /// </summary>
        public const string PRBNOP = "PRBNOP";

        /// <summary>
        /// PRBSOP.
        /// </summary>
        public const string PRBSOP = "PRBSOP";

        /// <summary>
        /// PREPDJ.
        /// </summary>
        public const string PREPDJ = "PREPDJ";

        /// <summary>
        /// PRTORG.
        /// </summary>
        public const string PRTORG = "PRTORG";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRTDAY.
        /// </summary>
        public const string PRTDAY = "PRTDAY";

        /// <summary>
        /// PRBRTAX1.
        /// </summary>
        public const string PRBRTAX1 = "PRBRTAX1";

        /// <summary>
        /// PRBRTAX2.
        /// </summary>
        public const string PRBRTAX2 = "PRBRTAX2";

        /// <summary>
        /// PRBRTAX3.
        /// </summary>
        public const string PRBRTAX3 = "PRBRTAX3";

        /// <summary>
        /// PRBRTAX4.
        /// </summary>
        public const string PRBRTAX4 = "PRBRTAX4";

        /// <summary>
        /// PRBRTAX5.
        /// </summary>
        public const string PRBRTAX5 = "PRBRTAX5";

        /// <summary>
        /// PRBRTAX6.
        /// </summary>
        public const string PRBRTAX6 = "PRBRTAX6";

        /// <summary>
        /// PRBRTAX7.
        /// </summary>
        public const string PRBRTAX7 = "PRBRTAX7";

        /// <summary>
        /// PRBRTAX8.
        /// </summary>
        public const string PRBRTAX8 = "PRBRTAX8";

        /// <summary>
        /// PRBRIINS.
        /// </summary>
        public const string PRBRIINS = "PRBRIINS";
    }

    /// <inheritdoc />
    public override string TableName => "F76011P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRAN8", "PRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PRBMUN", "PRBMUN", JdeDataType.String, 24),
        new JdeField("PRBICC", "PRBICC", JdeDataType.String, 2),
        new JdeField("PRBIST", "PRBIST", JdeDataType.String, 2),
        new JdeField("PRBIRP", "PRBIRP", JdeDataType.String, 2),
        new JdeField("PRBFII", "PRBFII", JdeDataType.String, 2),
        new JdeField("PRBFIP", "PRBFIP", JdeDataType.String, 2),
        new JdeField("PRBFIS", "PRBFIS", JdeDataType.String, 2),
        new JdeField("PRBZFR", "PRBZFR", JdeDataType.String, 2),
        new JdeField("PRBISC", "PRBISC", JdeDataType.String, 60),
        new JdeField("PRBCPF", "PRBCPF", JdeDataType.String, 22),
        new JdeField("PRBRG", "PRBRG", JdeDataType.String, 18),
        new JdeField("PRBSOE", "PRBSOE", JdeDataType.String, 10),
        new JdeField("PRADDS", "PRADDS", JdeDataType.String, 6),
        new JdeField("PRBAUT", "PRBAUT", JdeDataType.String, 24),
        new JdeField("PRCTY1", "PRCTY1", JdeDataType.String, 50),
        new JdeField("PRSTCD", "PRSTCD", JdeDataType.String, 6),
        new JdeField("PRBNOP", "PRBNOP", JdeDataType.Numeric),
        new JdeField("PRBSOP", "PRBSOP", JdeDataType.String, 4),
        new JdeField("PREPDJ", "PREPDJ", JdeDataType.Numeric),
        new JdeField("PRTORG", "PRTORG", JdeDataType.String, 20),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRTDAY", "PRTDAY", JdeDataType.Numeric),
        new JdeField("PRBRTAX1", "PRBRTAX1", JdeDataType.String, 16),
        new JdeField("PRBRTAX2", "PRBRTAX2", JdeDataType.String, 16),
        new JdeField("PRBRTAX3", "PRBRTAX3", JdeDataType.String, 16),
        new JdeField("PRBRTAX4", "PRBRTAX4", JdeDataType.String, 16),
        new JdeField("PRBRTAX5", "PRBRTAX5", JdeDataType.String, 16),
        new JdeField("PRBRTAX6", "PRBRTAX6", JdeDataType.String, 16),
        new JdeField("PRBRTAX7", "PRBRTAX7", JdeDataType.String, 16),
        new JdeField("PRBRTAX8", "PRBRTAX8", JdeDataType.String, 16),
        new JdeField("PRBRIINS", "PRBRIINS", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76011P_0", "Primary Key on PRAN8", new[] { "PRAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76011P_2", "Index on PRBCPF", new[] { "PRBCPF" })
    };
}
