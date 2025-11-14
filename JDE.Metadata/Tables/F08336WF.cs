using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08336WF - .
/// </summary>
public class F08336WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDEVET.
        /// </summary>
        public const string BDEVET = "BDEVET";

        /// <summary>
        /// BDAN8.
        /// </summary>
        public const string BDAN8 = "BDAN8";

        /// <summary>
        /// BDPAN8.
        /// </summary>
        public const string BDPAN8 = "BDPAN8";

        /// <summary>
        /// BDMLNM.
        /// </summary>
        public const string BDMLNM = "BDMLNM";

        /// <summary>
        /// BDDBEN.
        /// </summary>
        public const string BDDBEN = "BDDBEN";

        /// <summary>
        /// BDRELA.
        /// </summary>
        public const string BDRELA = "BDRELA";

        /// <summary>
        /// BDPLAN.
        /// </summary>
        public const string BDPLAN = "BDPLAN";

        /// <summary>
        /// BDAOPT.
        /// </summary>
        public const string BDAOPT = "BDAOPT";

        /// <summary>
        /// BDEFT.
        /// </summary>
        public const string BDEFT = "BDEFT";

        /// <summary>
        /// BDPCP#.
        /// </summary>
        public const string BDPCP_ = "BDPCP#";

        /// <summary>
        /// BDEFTE.
        /// </summary>
        public const string BDEFTE = "BDEFTE";

        /// <summary>
        /// BDEECD.
        /// </summary>
        public const string BDEECD = "BDEECD";

        /// <summary>
        /// BDEDTE.
        /// </summary>
        public const string BDEDTE = "BDEDTE";

        /// <summary>
        /// BDPERC.
        /// </summary>
        public const string BDPERC = "BDPERC";

        /// <summary>
        /// BDSECPERC.
        /// </summary>
        public const string BDSECPERC = "BDSECPERC";

        /// <summary>
        /// BDNEWPERC.
        /// </summary>
        public const string BDNEWPERC = "BDNEWPERC";

        /// <summary>
        /// BDNSECPERC.
        /// </summary>
        public const string BDNSECPERC = "BDNSECPERC";

        /// <summary>
        /// BDACFL.
        /// </summary>
        public const string BDACFL = "BDACFL";

        /// <summary>
        /// BDUSER.
        /// </summary>
        public const string BDUSER = "BDUSER";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";

        /// <summary>
        /// BDJOBN.
        /// </summary>
        public const string BDJOBN = "BDJOBN";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";

        /// <summary>
        /// BDUPMT.
        /// </summary>
        public const string BDUPMT = "BDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08336WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDEVET", "BDEVET", JdeDataType.Numeric, null, true, true),
        new JdeField("BDAN8", "BDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BDPAN8", "BDPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BDMLNM", "BDMLNM", JdeDataType.String, 80),
        new JdeField("BDDBEN", "BDDBEN", JdeDataType.String, 2, true, true),
        new JdeField("BDRELA", "BDRELA", JdeDataType.String, 2),
        new JdeField("BDPLAN", "BDPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BDAOPT", "BDAOPT", JdeDataType.String, 6, true, true),
        new JdeField("BDEFT", "BDEFT", JdeDataType.Numeric),
        new JdeField("BDPCP#", "BDPCP#", JdeDataType.String, 40),
        new JdeField("BDEFTE", "BDEFTE", JdeDataType.Numeric),
        new JdeField("BDEECD", "BDEECD", JdeDataType.String, 6),
        new JdeField("BDEDTE", "BDEDTE", JdeDataType.Numeric),
        new JdeField("BDPERC", "BDPERC", JdeDataType.Numeric),
        new JdeField("BDSECPERC", "BDSECPERC", JdeDataType.Numeric),
        new JdeField("BDNEWPERC", "BDNEWPERC", JdeDataType.Numeric),
        new JdeField("BDNSECPERC", "BDNSECPERC", JdeDataType.Numeric),
        new JdeField("BDACFL", "BDACFL", JdeDataType.String, 2),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDJOBN", "BDJOBN", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDUPMT", "BDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08336WF_0", "Primary Key on BDEVET, BDAN8, BDPAN8, BDPLAN, BDAOPT, BDDBEN", new[] { "BDEVET", "BDAN8", "BDPAN8", "BDPLAN", "BDAOPT", "BDDBEN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08336WF_2", "Unique Index on BDAN8, BDPAN8, BDPLAN, BDAOPT, BDEVET", new[] { "BDAN8", "BDPAN8", "BDPLAN", "BDAOPT", "BDEVET" }, isUnique: true)
    };
}
