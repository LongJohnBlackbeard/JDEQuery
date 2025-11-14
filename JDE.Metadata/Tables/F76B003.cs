using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B003 - .
/// </summary>
public class F76B003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PUBCFC.
        /// </summary>
        public const string PUBCFC = "PUBCFC";

        /// <summary>
        /// PUBTPIS.
        /// </summary>
        public const string PUBTPIS = "PUBTPIS";

        /// <summary>
        /// PUBFPIS.
        /// </summary>
        public const string PUBFPIS = "PUBFPIS";

        /// <summary>
        /// PUBTCOF.
        /// </summary>
        public const string PUBTCOF = "PUBTCOF";

        /// <summary>
        /// PUBFCOF.
        /// </summary>
        public const string PUBFCOF = "PUBFCOF";

        /// <summary>
        /// PUBTAX1.
        /// </summary>
        public const string PUBTAX1 = "PUBTAX1";

        /// <summary>
        /// PUBFTAX1.
        /// </summary>
        public const string PUBFTAX1 = "PUBFTAX1";

        /// <summary>
        /// PUBTAX2.
        /// </summary>
        public const string PUBTAX2 = "PUBTAX2";

        /// <summary>
        /// PUBFTAX2.
        /// </summary>
        public const string PUBFTAX2 = "PUBFTAX2";

        /// <summary>
        /// PUBTAX3.
        /// </summary>
        public const string PUBTAX3 = "PUBTAX3";

        /// <summary>
        /// PUBFTAX3.
        /// </summary>
        public const string PUBFTAX3 = "PUBFTAX3";

        /// <summary>
        /// PUBTAX4.
        /// </summary>
        public const string PUBTAX4 = "PUBTAX4";

        /// <summary>
        /// PUBFTAX4.
        /// </summary>
        public const string PUBFTAX4 = "PUBFTAX4";

        /// <summary>
        /// PUBTAX5.
        /// </summary>
        public const string PUBTAX5 = "PUBTAX5";

        /// <summary>
        /// PUBFTAX5.
        /// </summary>
        public const string PUBFTAX5 = "PUBFTAX5";

        /// <summary>
        /// PUBTAX6.
        /// </summary>
        public const string PUBTAX6 = "PUBTAX6";

        /// <summary>
        /// PUBFTAX6.
        /// </summary>
        public const string PUBFTAX6 = "PUBFTAX6";

        /// <summary>
        /// PUBTAX7.
        /// </summary>
        public const string PUBTAX7 = "PUBTAX7";

        /// <summary>
        /// PUBFTAX7.
        /// </summary>
        public const string PUBFTAX7 = "PUBFTAX7";

        /// <summary>
        /// PUBTAX8.
        /// </summary>
        public const string PUBTAX8 = "PUBTAX8";

        /// <summary>
        /// PUBFTAX8.
        /// </summary>
        public const string PUBFTAX8 = "PUBFTAX8";

        /// <summary>
        /// PUBTAX9.
        /// </summary>
        public const string PUBTAX9 = "PUBTAX9";

        /// <summary>
        /// PUBFTAX9.
        /// </summary>
        public const string PUBFTAX9 = "PUBFTAX9";

        /// <summary>
        /// PUBTAX10.
        /// </summary>
        public const string PUBTAX10 = "PUBTAX10";

        /// <summary>
        /// PUBFTAX10.
        /// </summary>
        public const string PUBFTAX10 = "PUBFTAX10";

        /// <summary>
        /// PUBFIPIR.
        /// </summary>
        public const string PUBFIPIR = "PUBFIPIR";

        /// <summary>
        /// PUBFICMSR.
        /// </summary>
        public const string PUBFICMSR = "PUBFICMSR";

        /// <summary>
        /// PUBFICMSSR.
        /// </summary>
        public const string PUBFICMSSR = "PUBFICMSSR";

        /// <summary>
        /// PUBFTNPU.
        /// </summary>
        public const string PUBFTNPU = "PUBFTNPU";

        /// <summary>
        /// PUC1FU.
        /// </summary>
        public const string PUC1FU = "PUC1FU";

        /// <summary>
        /// PUC2FU.
        /// </summary>
        public const string PUC2FU = "PUC2FU";

        /// <summary>
        /// PUD1FU.
        /// </summary>
        public const string PUD1FU = "PUD1FU";

        /// <summary>
        /// PUD2FU.
        /// </summary>
        public const string PUD2FU = "PUD2FU";

        /// <summary>
        /// PUR1FU.
        /// </summary>
        public const string PUR1FU = "PUR1FU";

        /// <summary>
        /// PUN1FU.
        /// </summary>
        public const string PUN1FU = "PUN1FU";

        /// <summary>
        /// PUN8FU.
        /// </summary>
        public const string PUN8FU = "PUN8FU";

        /// <summary>
        /// PUN4FU.
        /// </summary>
        public const string PUN4FU = "PUN4FU";

        /// <summary>
        /// PUN5FU.
        /// </summary>
        public const string PUN5FU = "PUN5FU";

        /// <summary>
        /// PUN6FU.
        /// </summary>
        public const string PUN6FU = "PUN6FU";

        /// <summary>
        /// PUN7FU.
        /// </summary>
        public const string PUN7FU = "PUN7FU";

        /// <summary>
        /// PUS1FU.
        /// </summary>
        public const string PUS1FU = "PUS1FU";

        /// <summary>
        /// PUS3FU.
        /// </summary>
        public const string PUS3FU = "PUS3FU";

        /// <summary>
        /// PUS4FU.
        /// </summary>
        public const string PUS4FU = "PUS4FU";

        /// <summary>
        /// PUGENLNG.
        /// </summary>
        public const string PUGENLNG = "PUGENLNG";

        /// <summary>
        /// PUTORG.
        /// </summary>
        public const string PUTORG = "PUTORG";

        /// <summary>
        /// PUUSER.
        /// </summary>
        public const string PUUSER = "PUUSER";

        /// <summary>
        /// PUPID.
        /// </summary>
        public const string PUPID = "PUPID";

        /// <summary>
        /// PUJOBN.
        /// </summary>
        public const string PUJOBN = "PUJOBN";

        /// <summary>
        /// PUUPMJ.
        /// </summary>
        public const string PUUPMJ = "PUUPMJ";

        /// <summary>
        /// PUUPMT.
        /// </summary>
        public const string PUUPMT = "PUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PUBCFC", "PUBCFC", JdeDataType.String, 6, true, true),
        new JdeField("PUBTPIS", "PUBTPIS", JdeDataType.String, 16),
        new JdeField("PUBFPIS", "PUBFPIS", JdeDataType.String, 2),
        new JdeField("PUBTCOF", "PUBTCOF", JdeDataType.String, 16),
        new JdeField("PUBFCOF", "PUBFCOF", JdeDataType.String, 2),
        new JdeField("PUBTAX1", "PUBTAX1", JdeDataType.String, 16),
        new JdeField("PUBFTAX1", "PUBFTAX1", JdeDataType.String, 2),
        new JdeField("PUBTAX2", "PUBTAX2", JdeDataType.String, 16),
        new JdeField("PUBFTAX2", "PUBFTAX2", JdeDataType.String, 2),
        new JdeField("PUBTAX3", "PUBTAX3", JdeDataType.String, 16),
        new JdeField("PUBFTAX3", "PUBFTAX3", JdeDataType.String, 2),
        new JdeField("PUBTAX4", "PUBTAX4", JdeDataType.String, 16),
        new JdeField("PUBFTAX4", "PUBFTAX4", JdeDataType.String, 2),
        new JdeField("PUBTAX5", "PUBTAX5", JdeDataType.String, 16),
        new JdeField("PUBFTAX5", "PUBFTAX5", JdeDataType.String, 2),
        new JdeField("PUBTAX6", "PUBTAX6", JdeDataType.String, 16),
        new JdeField("PUBFTAX6", "PUBFTAX6", JdeDataType.String, 2),
        new JdeField("PUBTAX7", "PUBTAX7", JdeDataType.String, 16),
        new JdeField("PUBFTAX7", "PUBFTAX7", JdeDataType.String, 2),
        new JdeField("PUBTAX8", "PUBTAX8", JdeDataType.String, 16),
        new JdeField("PUBFTAX8", "PUBFTAX8", JdeDataType.String, 2),
        new JdeField("PUBTAX9", "PUBTAX9", JdeDataType.String, 16),
        new JdeField("PUBFTAX9", "PUBFTAX9", JdeDataType.String, 2),
        new JdeField("PUBTAX10", "PUBTAX10", JdeDataType.String, 16),
        new JdeField("PUBFTAX10", "PUBFTAX10", JdeDataType.String, 2),
        new JdeField("PUBFIPIR", "PUBFIPIR", JdeDataType.String, 2),
        new JdeField("PUBFICMSR", "PUBFICMSR", JdeDataType.String, 2),
        new JdeField("PUBFICMSSR", "PUBFICMSSR", JdeDataType.String, 2),
        new JdeField("PUBFTNPU", "PUBFTNPU", JdeDataType.String, 2),
        new JdeField("PUC1FU", "PUC1FU", JdeDataType.String, 2),
        new JdeField("PUC2FU", "PUC2FU", JdeDataType.String, 2),
        new JdeField("PUD1FU", "PUD1FU", JdeDataType.Numeric),
        new JdeField("PUD2FU", "PUD2FU", JdeDataType.Numeric),
        new JdeField("PUR1FU", "PUR1FU", JdeDataType.Numeric),
        new JdeField("PUN1FU", "PUN1FU", JdeDataType.Numeric),
        new JdeField("PUN8FU", "PUN8FU", JdeDataType.Numeric),
        new JdeField("PUN4FU", "PUN4FU", JdeDataType.Numeric),
        new JdeField("PUN5FU", "PUN5FU", JdeDataType.Numeric),
        new JdeField("PUN6FU", "PUN6FU", JdeDataType.Numeric),
        new JdeField("PUN7FU", "PUN7FU", JdeDataType.Numeric),
        new JdeField("PUS1FU", "PUS1FU", JdeDataType.String, 60),
        new JdeField("PUS3FU", "PUS3FU", JdeDataType.String, 6),
        new JdeField("PUS4FU", "PUS4FU", JdeDataType.String, 6),
        new JdeField("PUGENLNG", "PUGENLNG", JdeDataType.Numeric),
        new JdeField("PUTORG", "PUTORG", JdeDataType.String, 20),
        new JdeField("PUUSER", "PUUSER", JdeDataType.String, 20),
        new JdeField("PUPID", "PUPID", JdeDataType.String, 20),
        new JdeField("PUJOBN", "PUJOBN", JdeDataType.String, 20),
        new JdeField("PUUPMJ", "PUUPMJ", JdeDataType.Numeric),
        new JdeField("PUUPMT", "PUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B003_0", "Primary Key on PUBCFC", new[] { "PUBCFC" }, isUnique: true, isPrimaryKey: true)
    };
}
