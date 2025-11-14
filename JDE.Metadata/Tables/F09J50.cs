using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J50 - .
/// </summary>
public class F09J50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OHJVOVN.
        /// </summary>
        public const string OHJVOVN = "OHJVOVN";

        /// <summary>
        /// OHJVOVD.
        /// </summary>
        public const string OHJVOVD = "OHJVOVD";

        /// <summary>
        /// OHTORG.
        /// </summary>
        public const string OHTORG = "OHTORG";

        /// <summary>
        /// OHENTJ.
        /// </summary>
        public const string OHENTJ = "OHENTJ";

        /// <summary>
        /// OHUSER.
        /// </summary>
        public const string OHUSER = "OHUSER";

        /// <summary>
        /// OHUPMJ.
        /// </summary>
        public const string OHUPMJ = "OHUPMJ";

        /// <summary>
        /// OHUPMT.
        /// </summary>
        public const string OHUPMT = "OHUPMT";

        /// <summary>
        /// OHPID.
        /// </summary>
        public const string OHPID = "OHPID";

        /// <summary>
        /// OHMKEY.
        /// </summary>
        public const string OHMKEY = "OHMKEY";

        /// <summary>
        /// OHJVOHCC1.
        /// </summary>
        public const string OHJVOHCC1 = "OHJVOHCC1";

        /// <summary>
        /// OHJVOHCC2.
        /// </summary>
        public const string OHJVOHCC2 = "OHJVOHCC2";

        /// <summary>
        /// OHJVOHCC3.
        /// </summary>
        public const string OHJVOHCC3 = "OHJVOHCC3";

        /// <summary>
        /// OHJVOHCC4.
        /// </summary>
        public const string OHJVOHCC4 = "OHJVOHCC4";

        /// <summary>
        /// OHJVOHCC5.
        /// </summary>
        public const string OHJVOHCC5 = "OHJVOHCC5";

        /// <summary>
        /// OHJVOHCC6.
        /// </summary>
        public const string OHJVOHCC6 = "OHJVOHCC6";

        /// <summary>
        /// OHJVOHCC7.
        /// </summary>
        public const string OHJVOHCC7 = "OHJVOHCC7";

        /// <summary>
        /// OHJVOHCC8.
        /// </summary>
        public const string OHJVOHCC8 = "OHJVOHCC8";

        /// <summary>
        /// OHJVOHCC9.
        /// </summary>
        public const string OHJVOHCC9 = "OHJVOHCC9";

        /// <summary>
        /// OHJVOHCC10.
        /// </summary>
        public const string OHJVOHCC10 = "OHJVOHCC10";

        /// <summary>
        /// OHJVBNU1.
        /// </summary>
        public const string OHJVBNU1 = "OHJVBNU1";

        /// <summary>
        /// OHJVBNU2.
        /// </summary>
        public const string OHJVBNU2 = "OHJVBNU2";

        /// <summary>
        /// OHJVBNU3.
        /// </summary>
        public const string OHJVBNU3 = "OHJVBNU3";

        /// <summary>
        /// OHJVBST1.
        /// </summary>
        public const string OHJVBST1 = "OHJVBST1";

        /// <summary>
        /// OHJVBST2.
        /// </summary>
        public const string OHJVBST2 = "OHJVBST2";

        /// <summary>
        /// OHJVBST3.
        /// </summary>
        public const string OHJVBST3 = "OHJVBST3";

        /// <summary>
        /// OHJVBCH1.
        /// </summary>
        public const string OHJVBCH1 = "OHJVBCH1";

        /// <summary>
        /// OHJVBCH2.
        /// </summary>
        public const string OHJVBCH2 = "OHJVBCH2";

        /// <summary>
        /// OHJVBCH3.
        /// </summary>
        public const string OHJVBCH3 = "OHJVBCH3";

        /// <summary>
        /// OHJVBDT1.
        /// </summary>
        public const string OHJVBDT1 = "OHJVBDT1";

        /// <summary>
        /// OHJVBDT2.
        /// </summary>
        public const string OHJVBDT2 = "OHJVBDT2";

        /// <summary>
        /// OHJVBDT3.
        /// </summary>
        public const string OHJVBDT3 = "OHJVBDT3";

        /// <summary>
        /// OHURATR01.
        /// </summary>
        public const string OHURATR01 = "OHURATR01";

        /// <summary>
        /// OHURATR02.
        /// </summary>
        public const string OHURATR02 = "OHURATR02";

        /// <summary>
        /// OHURATR03.
        /// </summary>
        public const string OHURATR03 = "OHURATR03";

        /// <summary>
        /// OHURATR04.
        /// </summary>
        public const string OHURATR04 = "OHURATR04";

        /// <summary>
        /// OHURATR05.
        /// </summary>
        public const string OHURATR05 = "OHURATR05";

        /// <summary>
        /// OHURCDR01.
        /// </summary>
        public const string OHURCDR01 = "OHURCDR01";

        /// <summary>
        /// OHURCDR02.
        /// </summary>
        public const string OHURCDR02 = "OHURCDR02";

        /// <summary>
        /// OHURCDR03.
        /// </summary>
        public const string OHURCDR03 = "OHURCDR03";

        /// <summary>
        /// OHURCDR04.
        /// </summary>
        public const string OHURCDR04 = "OHURCDR04";

        /// <summary>
        /// OHURCDR05.
        /// </summary>
        public const string OHURCDR05 = "OHURCDR05";

        /// <summary>
        /// OHURDTR01.
        /// </summary>
        public const string OHURDTR01 = "OHURDTR01";

        /// <summary>
        /// OHURDTR02.
        /// </summary>
        public const string OHURDTR02 = "OHURDTR02";

        /// <summary>
        /// OHURDTR03.
        /// </summary>
        public const string OHURDTR03 = "OHURDTR03";

        /// <summary>
        /// OHURDTR04.
        /// </summary>
        public const string OHURDTR04 = "OHURDTR04";

        /// <summary>
        /// OHURDTR05.
        /// </summary>
        public const string OHURDTR05 = "OHURDTR05";

        /// <summary>
        /// OHURNUMR01.
        /// </summary>
        public const string OHURNUMR01 = "OHURNUMR01";

        /// <summary>
        /// OHURNUMR02.
        /// </summary>
        public const string OHURNUMR02 = "OHURNUMR02";

        /// <summary>
        /// OHURNUMR03.
        /// </summary>
        public const string OHURNUMR03 = "OHURNUMR03";

        /// <summary>
        /// OHURNUMR04.
        /// </summary>
        public const string OHURNUMR04 = "OHURNUMR04";

        /// <summary>
        /// OHURNUMR05.
        /// </summary>
        public const string OHURNUMR05 = "OHURNUMR05";

        /// <summary>
        /// OHURRFR01.
        /// </summary>
        public const string OHURRFR01 = "OHURRFR01";

        /// <summary>
        /// OHURRFR02.
        /// </summary>
        public const string OHURRFR02 = "OHURRFR02";

        /// <summary>
        /// OHURRFR03.
        /// </summary>
        public const string OHURRFR03 = "OHURRFR03";

        /// <summary>
        /// OHURRFR04.
        /// </summary>
        public const string OHURRFR04 = "OHURRFR04";

        /// <summary>
        /// OHURRFR05.
        /// </summary>
        public const string OHURRFR05 = "OHURRFR05";

        /// <summary>
        /// OHURSTR01.
        /// </summary>
        public const string OHURSTR01 = "OHURSTR01";

        /// <summary>
        /// OHURSTR02.
        /// </summary>
        public const string OHURSTR02 = "OHURSTR02";

        /// <summary>
        /// OHURSTR03.
        /// </summary>
        public const string OHURSTR03 = "OHURSTR03";

        /// <summary>
        /// OHURSTR04.
        /// </summary>
        public const string OHURSTR04 = "OHURSTR04";

        /// <summary>
        /// OHURSTR05.
        /// </summary>
        public const string OHURSTR05 = "OHURSTR05";
    }

    /// <inheritdoc />
    public override string TableName => "F09J50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OHJVOVN", "OHJVOVN", JdeDataType.String, 40, true, true),
        new JdeField("OHJVOVD", "OHJVOVD", JdeDataType.String, 160),
        new JdeField("OHTORG", "OHTORG", JdeDataType.String, 20),
        new JdeField("OHENTJ", "OHENTJ", JdeDataType.Numeric),
        new JdeField("OHUSER", "OHUSER", JdeDataType.String, 20),
        new JdeField("OHUPMJ", "OHUPMJ", JdeDataType.Numeric),
        new JdeField("OHUPMT", "OHUPMT", JdeDataType.Numeric),
        new JdeField("OHPID", "OHPID", JdeDataType.String, 20),
        new JdeField("OHMKEY", "OHMKEY", JdeDataType.String, 30),
        new JdeField("OHJVOHCC1", "OHJVOHCC1", JdeDataType.String, 20),
        new JdeField("OHJVOHCC2", "OHJVOHCC2", JdeDataType.String, 20),
        new JdeField("OHJVOHCC3", "OHJVOHCC3", JdeDataType.String, 20),
        new JdeField("OHJVOHCC4", "OHJVOHCC4", JdeDataType.String, 20),
        new JdeField("OHJVOHCC5", "OHJVOHCC5", JdeDataType.String, 20),
        new JdeField("OHJVOHCC6", "OHJVOHCC6", JdeDataType.String, 20),
        new JdeField("OHJVOHCC7", "OHJVOHCC7", JdeDataType.String, 20),
        new JdeField("OHJVOHCC8", "OHJVOHCC8", JdeDataType.String, 20),
        new JdeField("OHJVOHCC9", "OHJVOHCC9", JdeDataType.String, 20),
        new JdeField("OHJVOHCC10", "OHJVOHCC10", JdeDataType.String, 20),
        new JdeField("OHJVBNU1", "OHJVBNU1", JdeDataType.Numeric),
        new JdeField("OHJVBNU2", "OHJVBNU2", JdeDataType.Numeric),
        new JdeField("OHJVBNU3", "OHJVBNU3", JdeDataType.Numeric),
        new JdeField("OHJVBST1", "OHJVBST1", JdeDataType.String, 160),
        new JdeField("OHJVBST2", "OHJVBST2", JdeDataType.String, 160),
        new JdeField("OHJVBST3", "OHJVBST3", JdeDataType.String, 160),
        new JdeField("OHJVBCH1", "OHJVBCH1", JdeDataType.String, 2),
        new JdeField("OHJVBCH2", "OHJVBCH2", JdeDataType.String, 2),
        new JdeField("OHJVBCH3", "OHJVBCH3", JdeDataType.String, 2),
        new JdeField("OHJVBDT1", "OHJVBDT1", JdeDataType.Numeric),
        new JdeField("OHJVBDT2", "OHJVBDT2", JdeDataType.Numeric),
        new JdeField("OHJVBDT3", "OHJVBDT3", JdeDataType.Numeric),
        new JdeField("OHURATR01", "OHURATR01", JdeDataType.Numeric),
        new JdeField("OHURATR02", "OHURATR02", JdeDataType.Numeric),
        new JdeField("OHURATR03", "OHURATR03", JdeDataType.Numeric),
        new JdeField("OHURATR04", "OHURATR04", JdeDataType.Numeric),
        new JdeField("OHURATR05", "OHURATR05", JdeDataType.Numeric),
        new JdeField("OHURCDR01", "OHURCDR01", JdeDataType.String, 20),
        new JdeField("OHURCDR02", "OHURCDR02", JdeDataType.String, 20),
        new JdeField("OHURCDR03", "OHURCDR03", JdeDataType.String, 20),
        new JdeField("OHURCDR04", "OHURCDR04", JdeDataType.String, 20),
        new JdeField("OHURCDR05", "OHURCDR05", JdeDataType.String, 20),
        new JdeField("OHURDTR01", "OHURDTR01", JdeDataType.Numeric),
        new JdeField("OHURDTR02", "OHURDTR02", JdeDataType.Numeric),
        new JdeField("OHURDTR03", "OHURDTR03", JdeDataType.Numeric),
        new JdeField("OHURDTR04", "OHURDTR04", JdeDataType.Numeric),
        new JdeField("OHURDTR05", "OHURDTR05", JdeDataType.Numeric),
        new JdeField("OHURNUMR01", "OHURNUMR01", JdeDataType.Numeric),
        new JdeField("OHURNUMR02", "OHURNUMR02", JdeDataType.Numeric),
        new JdeField("OHURNUMR03", "OHURNUMR03", JdeDataType.Numeric),
        new JdeField("OHURNUMR04", "OHURNUMR04", JdeDataType.Numeric),
        new JdeField("OHURNUMR05", "OHURNUMR05", JdeDataType.Numeric),
        new JdeField("OHURRFR01", "OHURRFR01", JdeDataType.String, 30),
        new JdeField("OHURRFR02", "OHURRFR02", JdeDataType.String, 30),
        new JdeField("OHURRFR03", "OHURRFR03", JdeDataType.String, 30),
        new JdeField("OHURRFR04", "OHURRFR04", JdeDataType.String, 30),
        new JdeField("OHURRFR05", "OHURRFR05", JdeDataType.String, 30),
        new JdeField("OHURSTR01", "OHURSTR01", JdeDataType.String, 160),
        new JdeField("OHURSTR02", "OHURSTR02", JdeDataType.String, 160),
        new JdeField("OHURSTR03", "OHURSTR03", JdeDataType.String, 160),
        new JdeField("OHURSTR04", "OHURSTR04", JdeDataType.String, 160),
        new JdeField("OHURSTR05", "OHURSTR05", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J50_0", "Primary Key on OHJVOVN", new[] { "OHJVOVN" }, isUnique: true, isPrimaryKey: true)
    };
}
