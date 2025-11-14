using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I406 - .
/// </summary>
public class F75I406 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SBCO.
        /// </summary>
        public const string SBCO = "SBCO";

        /// <summary>
        /// SBMCU.
        /// </summary>
        public const string SBMCU = "SBMCU";

        /// <summary>
        /// SBADSO.
        /// </summary>
        public const string SBADSO = "SBADSO";

        /// <summary>
        /// SBDL01.
        /// </summary>
        public const string SBDL01 = "SBDL01";

        /// <summary>
        /// SBDL02.
        /// </summary>
        public const string SBDL02 = "SBDL02";

        /// <summary>
        /// SBDL03.
        /// </summary>
        public const string SBDL03 = "SBDL03";

        /// <summary>
        /// SBDL04.
        /// </summary>
        public const string SBDL04 = "SBDL04";

        /// <summary>
        /// SBDL05.
        /// </summary>
        public const string SBDL05 = "SBDL05";

        /// <summary>
        /// SBAIS1.
        /// </summary>
        public const string SBAIS1 = "SBAIS1";

        /// <summary>
        /// SBAIS2.
        /// </summary>
        public const string SBAIS2 = "SBAIS2";

        /// <summary>
        /// SBAIS3.
        /// </summary>
        public const string SBAIS3 = "SBAIS3";

        /// <summary>
        /// SBAIS4.
        /// </summary>
        public const string SBAIS4 = "SBAIS4";

        /// <summary>
        /// SBAIS5.
        /// </summary>
        public const string SBAIS5 = "SBAIS5";

        /// <summary>
        /// SBDATE01.
        /// </summary>
        public const string SBDATE01 = "SBDATE01";

        /// <summary>
        /// SBDATE02.
        /// </summary>
        public const string SBDATE02 = "SBDATE02";

        /// <summary>
        /// SBDATE03.
        /// </summary>
        public const string SBDATE03 = "SBDATE03";

        /// <summary>
        /// SBDATE04.
        /// </summary>
        public const string SBDATE04 = "SBDATE04";

        /// <summary>
        /// SBDATE05.
        /// </summary>
        public const string SBDATE05 = "SBDATE05";

        /// <summary>
        /// SBFL01.
        /// </summary>
        public const string SBFL01 = "SBFL01";

        /// <summary>
        /// SBFL02.
        /// </summary>
        public const string SBFL02 = "SBFL02";

        /// <summary>
        /// SBFL03.
        /// </summary>
        public const string SBFL03 = "SBFL03";

        /// <summary>
        /// SBFL04.
        /// </summary>
        public const string SBFL04 = "SBFL04";

        /// <summary>
        /// SBFL05.
        /// </summary>
        public const string SBFL05 = "SBFL05";

        /// <summary>
        /// SBUKID.
        /// </summary>
        public const string SBUKID = "SBUKID";

        /// <summary>
        /// SBPID.
        /// </summary>
        public const string SBPID = "SBPID";

        /// <summary>
        /// SBJOBN.
        /// </summary>
        public const string SBJOBN = "SBJOBN";

        /// <summary>
        /// SBUSER.
        /// </summary>
        public const string SBUSER = "SBUSER";

        /// <summary>
        /// SBUPMT.
        /// </summary>
        public const string SBUPMT = "SBUPMT";

        /// <summary>
        /// SBUPMJ.
        /// </summary>
        public const string SBUPMJ = "SBUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F75I406";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SBCO", "SBCO", JdeDataType.String, 10),
        new JdeField("SBMCU", "SBMCU", JdeDataType.String, 24, true, true),
        new JdeField("SBADSO", "SBADSO", JdeDataType.String, 6),
        new JdeField("SBDL01", "SBDL01", JdeDataType.String, 60),
        new JdeField("SBDL02", "SBDL02", JdeDataType.String, 60),
        new JdeField("SBDL03", "SBDL03", JdeDataType.String, 60),
        new JdeField("SBDL04", "SBDL04", JdeDataType.String, 60),
        new JdeField("SBDL05", "SBDL05", JdeDataType.String, 60),
        new JdeField("SBAIS1", "SBAIS1", JdeDataType.Numeric),
        new JdeField("SBAIS2", "SBAIS2", JdeDataType.Numeric),
        new JdeField("SBAIS3", "SBAIS3", JdeDataType.Numeric),
        new JdeField("SBAIS4", "SBAIS4", JdeDataType.Numeric),
        new JdeField("SBAIS5", "SBAIS5", JdeDataType.Numeric),
        new JdeField("SBDATE01", "SBDATE01", JdeDataType.Numeric),
        new JdeField("SBDATE02", "SBDATE02", JdeDataType.Numeric),
        new JdeField("SBDATE03", "SBDATE03", JdeDataType.Numeric),
        new JdeField("SBDATE04", "SBDATE04", JdeDataType.Numeric),
        new JdeField("SBDATE05", "SBDATE05", JdeDataType.Numeric),
        new JdeField("SBFL01", "SBFL01", JdeDataType.String, 2),
        new JdeField("SBFL02", "SBFL02", JdeDataType.String, 2),
        new JdeField("SBFL03", "SBFL03", JdeDataType.String, 2),
        new JdeField("SBFL04", "SBFL04", JdeDataType.String, 2),
        new JdeField("SBFL05", "SBFL05", JdeDataType.String, 2),
        new JdeField("SBUKID", "SBUKID", JdeDataType.Numeric),
        new JdeField("SBPID", "SBPID", JdeDataType.String, 20),
        new JdeField("SBJOBN", "SBJOBN", JdeDataType.String, 20),
        new JdeField("SBUSER", "SBUSER", JdeDataType.String, 20),
        new JdeField("SBUPMT", "SBUPMT", JdeDataType.Numeric),
        new JdeField("SBUPMJ", "SBUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I406_0", "Primary Key on SBMCU", new[] { "SBMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
