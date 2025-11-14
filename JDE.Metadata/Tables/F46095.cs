using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46095 - .
/// </summary>
public class F46095 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ETMCU.
        /// </summary>
        public const string ETMCU = "ETMCU";

        /// <summary>
        /// ETMPUT.
        /// </summary>
        public const string ETMPUT = "ETMPUT";

        /// <summary>
        /// ETMPIK.
        /// </summary>
        public const string ETMPIK = "ETMPIK";

        /// <summary>
        /// ETMRPL.
        /// </summary>
        public const string ETMRPL = "ETMRPL";

        /// <summary>
        /// ETPUTP.
        /// </summary>
        public const string ETPUTP = "ETPUTP";

        /// <summary>
        /// ETSEQ.
        /// </summary>
        public const string ETSEQ = "ETSEQ";

        /// <summary>
        /// ETUOM.
        /// </summary>
        public const string ETUOM = "ETUOM";

        /// <summary>
        /// ETUMGP.
        /// </summary>
        public const string ETUMGP = "ETUMGP";

        /// <summary>
        /// ETASUM.
        /// </summary>
        public const string ETASUM = "ETASUM";

        /// <summary>
        /// ETPRCD.
        /// </summary>
        public const string ETPRCD = "ETPRCD";

        /// <summary>
        /// ETSRUL.
        /// </summary>
        public const string ETSRUL = "ETSRUL";

        /// <summary>
        /// ETPZON.
        /// </summary>
        public const string ETPZON = "ETPZON";

        /// <summary>
        /// ETKZON.
        /// </summary>
        public const string ETKZON = "ETKZON";

        /// <summary>
        /// ETZONR.
        /// </summary>
        public const string ETZONR = "ETZONR";

        /// <summary>
        /// ETMLS1.
        /// </summary>
        public const string ETMLS1 = "ETMLS1";

        /// <summary>
        /// ETMLS2.
        /// </summary>
        public const string ETMLS2 = "ETMLS2";

        /// <summary>
        /// ETMLS3.
        /// </summary>
        public const string ETMLS3 = "ETMLS3";

        /// <summary>
        /// ETAMNU.
        /// </summary>
        public const string ETAMNU = "ETAMNU";

        /// <summary>
        /// ETAMPT.
        /// </summary>
        public const string ETAMPT = "ETAMPT";

        /// <summary>
        /// ETABKD.
        /// </summary>
        public const string ETABKD = "ETABKD";

        /// <summary>
        /// ETMERG.
        /// </summary>
        public const string ETMERG = "ETMERG";

        /// <summary>
        /// ETAMPK.
        /// </summary>
        public const string ETAMPK = "ETAMPK";

        /// <summary>
        /// ETKMNU.
        /// </summary>
        public const string ETKMNU = "ETKMNU";

        /// <summary>
        /// ETFIFX.
        /// </summary>
        public const string ETFIFX = "ETFIFX";

        /// <summary>
        /// ETAROL.
        /// </summary>
        public const string ETAROL = "ETAROL";

        /// <summary>
        /// ETARPL.
        /// </summary>
        public const string ETARPL = "ETARPL";

        /// <summary>
        /// ETOGRP.
        /// </summary>
        public const string ETOGRP = "ETOGRP";

        /// <summary>
        /// ETRQLY.
        /// </summary>
        public const string ETRQLY = "ETRQLY";

        /// <summary>
        /// ETOMOV.
        /// </summary>
        public const string ETOMOV = "ETOMOV";

        /// <summary>
        /// ETUSER.
        /// </summary>
        public const string ETUSER = "ETUSER";

        /// <summary>
        /// ETUPMJ.
        /// </summary>
        public const string ETUPMJ = "ETUPMJ";

        /// <summary>
        /// ETTDAY.
        /// </summary>
        public const string ETTDAY = "ETTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46095";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ETMCU", "ETMCU", JdeDataType.String, 24, true, true),
        new JdeField("ETMPUT", "ETMPUT", JdeDataType.String, 12, true, true),
        new JdeField("ETMPIK", "ETMPIK", JdeDataType.String, 12, true, true),
        new JdeField("ETMRPL", "ETMRPL", JdeDataType.String, 12, true, true),
        new JdeField("ETPUTP", "ETPUTP", JdeDataType.String, 2, true, true),
        new JdeField("ETSEQ", "ETSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ETUOM", "ETUOM", JdeDataType.String, 4),
        new JdeField("ETUMGP", "ETUMGP", JdeDataType.String, 4),
        new JdeField("ETASUM", "ETASUM", JdeDataType.Numeric),
        new JdeField("ETPRCD", "ETPRCD", JdeDataType.String, 2),
        new JdeField("ETSRUL", "ETSRUL", JdeDataType.String, 12),
        new JdeField("ETPZON", "ETPZON", JdeDataType.String, 12),
        new JdeField("ETKZON", "ETKZON", JdeDataType.String, 12),
        new JdeField("ETZONR", "ETZONR", JdeDataType.String, 12),
        new JdeField("ETMLS1", "ETMLS1", JdeDataType.String, 2),
        new JdeField("ETMLS2", "ETMLS2", JdeDataType.String, 2),
        new JdeField("ETMLS3", "ETMLS3", JdeDataType.String, 2),
        new JdeField("ETAMNU", "ETAMNU", JdeDataType.String, 2),
        new JdeField("ETAMPT", "ETAMPT", JdeDataType.String, 2),
        new JdeField("ETABKD", "ETABKD", JdeDataType.String, 2),
        new JdeField("ETMERG", "ETMERG", JdeDataType.String, 2),
        new JdeField("ETAMPK", "ETAMPK", JdeDataType.String, 2),
        new JdeField("ETKMNU", "ETKMNU", JdeDataType.String, 2),
        new JdeField("ETFIFX", "ETFIFX", JdeDataType.String, 2),
        new JdeField("ETAROL", "ETAROL", JdeDataType.String, 2),
        new JdeField("ETARPL", "ETARPL", JdeDataType.String, 2),
        new JdeField("ETOGRP", "ETOGRP", JdeDataType.String, 8),
        new JdeField("ETRQLY", "ETRQLY", JdeDataType.String, 2),
        new JdeField("ETOMOV", "ETOMOV", JdeDataType.String, 2),
        new JdeField("ETUSER", "ETUSER", JdeDataType.String, 20),
        new JdeField("ETUPMJ", "ETUPMJ", JdeDataType.Numeric),
        new JdeField("ETTDAY", "ETTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46095_0", "Primary Key on ETMCU, ETPUTP, ETMPUT, ETMPIK, ETMRPL, ETSEQ", new[] { "ETMCU", "ETPUTP", "ETMPUT", "ETMPIK", "ETMRPL", "ETSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
